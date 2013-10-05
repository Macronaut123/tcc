using UnityEngine;
using System.Collections;

public class DialogueTemplate : MonoBehaviour {
	
	/*
	 * This is an example of how to use the dialogue engine in C#, it shows you which functions are needed to get
	 * a basic, yet fully functional setup.
	 * Feel free to just copy and paste this code to where you need it :)
	*/
	
	public string filename = "ExampleDialogue";
	
	Dialogue d;				//Our Dialogue engine
	
	DialogueItem[] items;	//Our list of items we have to display
	
	bool talking = true;	//Should we show the GUI?
		
	void Start () {
		//Build a new dialogue system as you would with any plugin.
		d = new Dialogue(filename);
		
		//This is our first and most important function "GetNextOutput" (See docs). This will read and do most 
		//of the processing for a line of text and will return a .NET Array of DialogueItem containing the 
		//things to be displayed.
		items = d.GetNextOutput();
	}
	
	void OnGUI(){
		//This is the code to display the Dialogue.
		GUILayout.BeginArea( new Rect( Screen.width/2-100, Screen.height/2-100, 200, 200 ) );
		
			//Only do things when we're talking
			if( talking ){
			
				//items will contain an array of DialogueItems which 
				//each need to be processed seperately so we loop through 
				//each one.
				foreach( DialogueItem item in items ){
					
					//To make it easier to read most of the processing is 
					//done in this routine below.
					ProcessDialogueItem(item);
				
					//The easiest way to display things is with the Display 
					//routine attached to each DialoguItem
					DialogueItem retrn = item.Display( d );
					
					//On certain occasions the display function will send 
					//things back, these can be processed with the same 
					//routine as earlier.
					if( retrn != null ){
						ProcessDialogueItem( retrn );
					}
				}
				//When the item is just text we need a way to move it to the 
				//next line, so lets create a button.
				if( items[0].type == DialogueItem.ItemType.Text ){
					if( GUILayout.Button("Next") )
						items = d.GetNextOutput();
				}
			}
		
		GUILayout.EndArea();
	}
	
	void ProcessDialogueItem( DialogueItem item ){
		//This routine will process all the dialogue items returned for you,
		//feel free to copy and paste this into your project. :)
		
		//Calls need to be made with a method like SendMessage, we then need
		//to get the next output so we dont get odd buttons.
		if( item.type == DialogueItem.ItemType.Call ){
			SendMessage(item.content,item.parameter);
			items = d.GetNextOutput();
		}
		
		//Ends simply need to close the GUI, in this example we can just set
		//talking to false
		if( item.type == DialogueItem.ItemType.Endmark )
			talking = false;
		
		//Gotos are mostly handled by the engine but after options you just 
		//need to get the next output.
		if( item.type == DialogueItem.ItemType.Goto )
			items = d.GetNextOutput();
	}
	
	//Here you would have any functions that are called by the script, as 
	//some examples:
	void BuyCarrots( string quantity ){
		Debug.Log("Call: BuyCarrots(" + quantity +")");
	}
	
	void BuySpade(){
		Debug.Log("Call: BuySpade()");
	}
	
	void BuyColdplay(){
		Debug.Log("Call: BuyColdplay()");
	}	
}
