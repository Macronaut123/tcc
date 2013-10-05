using UnityEngine;
using System.Collections;

public class DemoAI : MonoBehaviour {
	
	public string filename = "ExampleDialogue";
	
	Dialogue d;				//Our Dialogue engine
	DialogueItem[] items;	//Our list of items we have to display
	bool talking = false;	//Are we talking?
	
	void Update () {
		Transform player = GameObject.Find("Player").transform;
		
		//A basic AI behaviour to always look at the Player
		transform.LookAt( player );
		
		//If they're in range we want to talk to them
		if( Vector3.Distance( transform.position, player.position ) < 5f ){
			//Display the script
			talking = true;
		}else{
			talking = false;
		}
		if( hasUpdated )
			hasUpdated = false;
	}
	
	void Start () {
		//Build a new dialogue system
		d = new Dialogue(filename);
		
		//Get some output
		items = d.GetNextOutput();
	}
	
	public bool hasUpdated;
	
	void OnGUI(){
		//This is the code to display the Dialogue, you'll notice 
		//it's a simplified version of the DialogueTemplate script, 
		//have a look at that to see it in more detail.
		
		GUILayout.BeginArea( new Rect( Screen.width/2-100, Screen.height/2-100, 200, 200 ) );
		
			//If we're talking lets start
			if( talking ){
				//Loop through all the items
				foreach( DialogueItem item in items ){
					
					ProcessDialogueItem(item);
				
					//Display it
					DialogueItem retrn = item.Display( d );
					
					if( retrn != null ){
						ProcessDialogueItem( retrn );
					}
				}
				if( items[0].type == DialogueItem.ItemType.Text ){
					if( GUILayout.Button("Next") )
						items = d.GetNextOutput();
				}
			}
		
		GUILayout.EndArea();
	}
	
	void ProcessDialogueItem( DialogueItem item ){
		//Process calls
		if( item.type == DialogueItem.ItemType.Call ){
			SendMessage(item.content,item.parameter);
			items = d.GetNextOutput();
		}
		//Process ends
		if( item.type == DialogueItem.ItemType.Endmark )
			talking = false;
		//Process gotos
		if( item.type == DialogueItem.ItemType.Goto )
			items = d.GetNextOutput();
	}
	
	void OutputString( string number ){
		Debug.Log("Hello!");
	}
}
