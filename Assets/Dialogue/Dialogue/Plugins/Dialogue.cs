using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueItem{
	/*
	 * This is how data is supplied back, as an option for the player to select, normal text an end marker
	 * or a call to some other code.
	*/
	
	//The display method will display the data for you using GUILayout (see Docs)
	
	public enum ItemType{ Text = 0, Option = 1, Call = 2, Goto = 3, Endmark = 4 }
	
	public string speaker;			//Who's speaking
	public string speech;			//What's being said
	public string content;			//Everything as one (also used for directions)
	public string direction;		//Used when data is a option as what needs to be executed on selection
	public ItemType type;			//The type of data
	public string parameter;		//A spare parameter for calls
	
	public DialogueItem( string speaker, string speech ){
		//A constructor for normal text
		this.type = ItemType.Text;
		this.speaker = speaker;
		this.speech = speech;
		this.content = speaker+": "+speech;
	}
	public DialogueItem( ItemType type, string text ){
		//A really short constructor for calls and gotos
		this.type = type;
		this.content = text;
	}
	public DialogueItem( ItemType type, string text, string direction ){
		//A second, longer, constructor for options
		this.type = type;
		this.content = text;
		this.direction = direction;
	}
	public DialogueItem( ItemType type ){
		//Another constructor for endmarks
		this.type = type;
	}
	
	public DialogueItem Display( Dialogue dialogueSystem ){
		//For calling from OnGUI to display the item and handling all stuff
		if( type == ItemType.Text ){
			//We are normal text so display in a label
			GUILayout.Label(speaker+" "+speech);
		}else{
			//We are an option so we need to process button presses
			if( GUILayout.Button(content) )
				return dialogueSystem.InterpretStageDirection( direction );
		}
		return null;
	}
}

public class Dialogue : System.Object{
	
	TextAsset file;
	
	string[] lines;
	Dictionary<string,int> labels;
	
	public int currentLine;
	
	public Dialogue(string filename){
		//Load file
		file = (TextAsset)Resources.Load( filename, typeof(TextAsset) );
		if( file == null ){
			Debug.LogError("[Dialogue] File did not load correctly, please check the filename and existance.");
			return;
		}
		
		//Parse
		lines = file.text.Split('\n');
		lines = RemoveComments( lines );
		labels = ResolveLabels( lines );
	}
	
	public void GotoLine( int lineNo ){
		//Goto a line referenced by number
		if( lineNo-1 >= 0 )
			currentLine = lineNo-1;
	}
	
	public int GotoLabel( string labelName ){
		//Goto a specified label (if it returns -1 the label was not found)
		int lineNo = GetLineNumberFromLabel( labelName );
		if( lineNo > -1 )
			currentLine = lineNo;
		return lineNo;
	}
	
	public int GetCurrentLineNumber(){
		//Get current line no.
		//N.B. Call this rather than accessing currentLine as it's always 1 ahead.
		return currentLine - 1;
	}	
	
	public string[] RemoveComments( string[] lines ){
		List<string> newLines = new List<string>();
		//Go through lines, removing comments and leading/trailing whitespace
		foreach( string line in lines ){
			string l = line;
			int index = l.IndexOf("//");
			if( index > -1 )
				l = l.Substring(0,index);
			//Lose indents etc
			l = l.Trim();
			//Remove tabs
			l = l.Replace("\t","");
			//Re-space out what people are saying
			l = l.Replace(":",": ");
			if( l != "" )
				newLines.Add(l);
		}
		return newLines.ToArray();
	}
	
	public Dictionary<string,int> ResolveLabels( string[] lines ){
		Dictionary<string,int> labels = new Dictionary<string,int>();
		//go through the lines remembering where each label is
		for( int l = 0; l < lines.Length; l++ ){
			if( lines[l][0].ToString() == "-" )
				labels.Add(lines[l].Substring(1),l);
		}
		return labels;
	}
	
	public DialogueItem[] GetNextOutput(){
		//This function returns the next thing to do or say
		DialogueItem[] output = null;
		
		//Early out if need be
		if( file == null ){
			Debug.LogError("[Dialogue] File was not loaded!!");
			return null;
		}
		
		//Keep looking if it is null or a goto
		while( output == null || output[0].type == DialogueItem.ItemType.Goto ){
			output = DoNextLine();
		}
		return output;
	}
	
	public DialogueItem[] DoNextLine(){
		DialogueItem[] items = new DialogueItem[1];			//Needed if we want to output just one... ugh...
		//Tell the user we've reached th end if need be.
		if( currentLine >= lines.Length ){
			items[0] = new DialogueItem( DialogueItem.ItemType.Endmark );
			return items;
		}
		//Go through looking for something to say
		string line = lines[currentLine];
		currentLine += 1;
		//Early out if there isn't a line...
		if( line == "" || line == null )
			return null;
		//Early out if we're a label
		if( line[0].ToString() == "-" )
			return null;
		//Sort out Questions
		if( line.IndexOf("{") > -1 ){
			List<DialogueItem> returns = InterpretMultipleChoice();
			if( returns != null )
				return returns.ToArray();
			else
				return null;
		}
		//Sort out Stage Directions
		if( line.IndexOf("[") > -1 ){
			DialogueItem direction = InterpretStageDirection( line );
			if( direction != null )
				items[0] = direction;
			else
				return null;
			return items;
		}
		items[0] = new DialogueItem( line.Substring(0,line.IndexOf(":")), line.Substring(line.IndexOf(":")) );
		return items;
	}
	
	public DialogueItem InterpretStageDirection( string line ){
		//Early out if there's no line
		if( line == "" || line == null )
			return null;
		//Cut out from square brackets if present
		int i = line.IndexOf("[");
		if( i > -1 )
			line = line.Substring( i+1 );
		i = line.IndexOf("]");
		if( i > -1 )
			line = line.Substring(0, i );
		//Split into instruction and direction
		string[] parts = line.Split(char.Parse(" "));

		if( parts[0] == "" ){
			Debug.LogError( "[Dialogue] Badly constructed direction in \"" + file.name + "\"." );
			return null;
		}
		
		DialogueItem item = null;
		
		//Sort out instruction
		switch( parts[0] ){
		case "goto":
			int lineNo = GetLineNumberFromLabel( parts[1] );
			if( lineNo > -1){
				item = new DialogueItem( DialogueItem.ItemType.Goto );
				currentLine = lineNo;
			}else{
				Debug.LogError( "[Dialogue] Could not find label \"" + parts[1] + "\" in \"" + file.name + "\"." );
			}
		break;
		case "call":
			item = new DialogueItem( DialogueItem.ItemType.Call, parts[1] );
			if( parts.Length > 2 )
				item.parameter = parts[2];
		break;
 		case "end":
			item = new DialogueItem( DialogueItem.ItemType.Endmark );
		break;
		default:
			Debug.LogError( "[Dialogue] Instruction \"" + parts[0] + "\" in \"" + file.name + "\" not recognised." );
			break;
		}
		return item;
	}
	
	public List<DialogueItem> InterpretMultipleChoice(){
		//This is where we store the options with their directions (Key is the part, Value is the value)
		List<Dictionary<string,string>> questionData = new List<Dictionary<string,string>>();
		//Build the data up in a list for use
		Dictionary<string,string> latestData = new Dictionary<string, string>();
		while( latestData != null ){
			latestData = GetQuestionDataFromNextLine();
			if( latestData != null )
				questionData.Add( latestData );
		}

		if( questionData.Count > 0 ){
			List<DialogueItem> options = new List<DialogueItem>();
			foreach( Dictionary<string,string> i in questionData )
				options.Add( new DialogueItem( DialogueItem.ItemType.Option, i["Option"], i["Direction"] ));
			return options;
		}else{
			return null;
		}
	}
	
	public Dictionary<string,string> GetQuestionDataFromNextLine(){
		//Make sure we've not gone over the edge
		if( currentLine >= lines.Length )
			return null;
		//Get our line
		string line = lines[currentLine-1];
		//Ensure we are actually an option and we haven't moved on
		if( line.IndexOf("{" ) > -1 ){
			currentLine += 1;
			//Build a dictionary to store:
			// - Option:	The text to display
			// - Direction:	The direction to perform if they select it
			Dictionary<string, string> splitItem = new Dictionary<string, string>();
			
			int fIndex = line.IndexOf("{");
			int lIndex = line.IndexOf("}");
			//Handle errors
			if( fIndex < 0 ){
				Debug.LogError( "[Dialogue] Option badly constructed (missing \"{\") in \"" + file.name + "\"." );
				return null;
			}else if( lIndex < 0){
				Debug.LogError( "[Dialogue] Option badly constructed (missing \"}\") in \"" + file.name + "\"." );
				return null;
			}else{
				//Get the text to display
				splitItem["Option"] = line.Substring( fIndex+1, lIndex-fIndex-1 );
			}
			
			int index = line.IndexOf("[");
			if( index < 0 ){
				//Handle errors
				Debug.LogError( "[Dialogue] Option badly constructed (missing direction) in \"" + file.name + "\"." );
				return null;
			}else{
				if( line.Length-index-1 < 0 ){
					//Handle more errors
					Debug.LogError( "[Dialogue] Option badly constructed (Square bracket error) in \"" + file.name + "\"." );
					return null;
				}
				splitItem["Direction"] = line.Substring( index, line.Length-index-1 );
				return splitItem;
			}
		}else{
			return null;
		}
	}
	
	public int GetLineNumberFromLabel( string labelName ){
		//This function gets the line number that a label was at
		foreach( KeyValuePair<string,int> label in labels ){
			if( label.Key == labelName )
				return label.Value;
		}
		return -1;
	}	
}