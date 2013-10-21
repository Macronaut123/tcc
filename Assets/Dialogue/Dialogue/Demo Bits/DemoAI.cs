using UnityEngine;
using System.Collections;

public class DemoAI : GenericFunction {
	
	public string filename;
	public string npc = "";
	public string specialContainer = "";
	public string fileName;
	Dialogue d;				//Our Dialogue engine
	DialogueItem[] items;	//Our list of items we have to display
	public bool talking = false;	//Are we talking?
	
	float timer;
	public float setTimer = 5f;
	
	void Start(){
		
		switch(gameObject.name){
		
			case "NPC_Klaus":
				setTimer = 5f;
			break;
			
			case "NPC_Persival":
				setTimer = 6f;
			break;
			
		}
		
		timer = setTimer;
	}
	
	public void OnTriggerEnter(Collider hit){
        if (hit.name == "Player"){
			talking = true;
			setDisableTime(false);
			gameObject.GetComponent<DisableObject>().disableAll(false);
		}else{
			talking = false;
			setDisableTime(true);
			gameObject.GetComponent<DisableObject>().disableAll(true);
		}
	}
	
	public void OnTriggerExit(Collider hit){
        if (hit.name == "Player"){
			talking = false;
			setDisableTime(true);
			gameObject.GetComponent<DisableObject>().disableAll(true);
		}
	}
	
	void Update () {
		
		//Transform player = GameObject.Find("Player").transform;
		
		//A basic AI behaviour to always look at the Player
		//transform.LookAt( player );
		
		//If they're in range we want to talk to them
		//if( Vector3.Distance( transform.position, player.position ) < 10f ){
			//Display the script
			//talking = true;
			//setDisableTime(false);
			//gameObject.GetComponent<DisableObject>().disableAll(false);
		//}else{
			//talking = false;
			//setDisableTime(true);
			//gameObject.GetComponent<DisableObject>().disableAll(true);
		//}
		
		
		if( hasUpdated )
			hasUpdated = false;
	}
	
	public void setFileName (string filename) {
		
		if(Application.loadedLevelName != "Zeitland" ){
			
			if(Application.loadedLevelName == "FINAL_DEFAULT" ){
				this.fileName = "FINAL_TXT/FINAL_DEFAULT";
			}
			else if(Application.loadedLevelName == "FINAL_GOOD" ){
				this.fileName = "FINAL_TXT/FINAL_GOOD";
			}
			else if(Application.loadedLevelName == "FINAL_PERFECT" ){
				this.fileName = "FINAL_TXT/FINAL_PERFECT";
			}
			else if(Application.loadedLevelName == "FINAL_BAD" ){
				this.fileName = "FINAL_TXT/FINAL_BAD";
			}
		}
		
		this.fileName = filename;
		this.timer = this.setTimer;
		
		//Build a new dialogue system
		Debug.Log("Try to load " + this.fileName); 
		d = new Dialogue(this.fileName);
		
		//Get some output
		items = d.GetNextOutput();
	}
	
	public bool hasUpdated;
	
	void OnGUI(){
		//This is the code to display the Dialogue, you'll notice 
		//it's a simplified version of the DialogueTemplate script, 
		//have a look at that to see it in more detail.
		
		GUILayout.BeginArea( new Rect( Screen.width/2 - 200, Screen.height/2 - 200, 200, 200 ) );
			//If we're talking lets start
			if(talking){
				//Loop through all the items
				foreach(DialogueItem item in items){
					
					ProcessDialogueItem(item);
				
					//Display it
					DialogueItem retrn = item.Display(d);
					
					if(retrn != null){
						ProcessDialogueItem(retrn);
					}
				}
				if(items[0].type == DialogueItem.ItemType.Text){
					timer -= Time.deltaTime;
						
						if(timer <= 0){
							items = d.GetNextOutput();
							timer = setTimer;
						}
				
					//if( GUILayout.Button("Next") )
					//	items = d.GetNextOutput();
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
	
	public void wpToMove(string comand){
		this.specialContainer = comand;
	}
	
	public void how(string gO){
		this.npc = gO;
	}
	
	public void calculeGoto(){
		GameObject.Find(npc).GetComponent<AiBasic>().defineCurrentContainer(GameObject.Find(specialContainer));
	}
	
	public void letter(string condition){
		var player = GameObject.Find("Player").GetComponent<NpcObjectives>();
		
		if(player.dependencyActions[condition] == true){
			if(GameObject.Find("NPC_Klaus").GetComponent<DemoAI>()){
				GameObject.Find("NPC_Klaus").GetComponent<DemoAI>().setFileName(this.fileName+"_"+"have_letter");
			}
			if(GameObject.Find("NPC_Persival").GetComponent<DemoAI>()){
				GameObject.Find("NPC_Persival").GetComponent<DemoAI>().setFileName(this.fileName+"_"+"have_letter");
			}
		}else{
			if(GameObject.Find("NPC_Klaus").GetComponent<DemoAI>()){
				GameObject.Find("NPC_Klaus").GetComponent<DemoAI>().setFileName(this.fileName+"_"+"dont_have_letter");
			}
			if(GameObject.Find("NPC_Persival").GetComponent<DemoAI>()){
				GameObject.Find("NPC_Persival").GetComponent<DemoAI>().setFileName(this.fileName+"_"+"dont_have_letter");
			}
		}
	}
	
	public void knowgunvar(string condition){
		var player = GameObject.Find("Player").GetComponent<NpcObjectives>();
		
		if(player.dependencyActions[condition] == true){
			if(GameObject.Find("NPC_Drake").GetComponent<DemoAI>()){
				GameObject.Find("NPC_Drake").GetComponent<DemoAI>().setFileName(this.fileName+"_"+"know_gunvar");
			}
		}else{
			if(GameObject.Find("NPC_Drake").GetComponent<DemoAI>()){
				GameObject.Find("NPC_Drake").GetComponent<DemoAI>().setFileName(this.fileName+"_"+"dont_know_gunvar");
			}
		}
	}
	
	public void knowriki(string condition){
		var player = GameObject.Find("Player").GetComponent<NpcObjectives>();
		
		if(player.dependencyActions[condition] == true){
			if(GameObject.Find("NPC_Drake").GetComponent<DemoAI>()){
				GameObject.Find("NPC_Drake").GetComponent<DemoAI>().setFileName("NPC_Drake/NPC_Drake_1430_know_riki");
			}
		}else{
			if(GameObject.Find("NPC_Drake").GetComponent<DemoAI>()){
				GameObject.Find("NPC_Drake").GetComponent<DemoAI>().setFileName("NPC_Drake/NPC_Drake_1430_dont_know_riki");
			}
		}
	}
	
	public void drop(string item){
		GameObject.Find(item).renderer.enabled = true;
		GameObject.Find(item).collider.enabled = true;
	}
	
	public void ignoreNpc(string npc){
		if(GameObject.Find(npc)){
			Destroy(GameObject.Find(npc).GetComponent<DemoAI>());
		}else{
			Debug.Log("NPC :" + npc + " not found");
		}
	}
}
