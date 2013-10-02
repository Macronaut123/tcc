using UnityEngine;
using System.Collections;

public class objetivos_001 : MonoBehaviour {
	
	private float global_timer;
	
	public bool obj_001 = false;
	public bool obj_002 = false;
	public bool obj_003 = false;
	public bool key_001 = false;
	
	public bool igreja = false;
	
	void OnTriggerEnter(Collider hit){

        switch (hit.name){

            case "igreja":

                igreja = true;

                break;

            case "NPC_villager_01":

                if (!obj_001)
                {
                    if (global_timer >= 7201)
                    {
                        obj_001 = true;
                    }
                }

                break;

            case "NPC_armazem":

                if (obj_001 && !obj_002)
                {
                    if (global_timer >= 3601)
                    {
                        obj_002 = true;
                    }
                }

                break;

            case "NPC_guardaForte":

                if (obj_001 && obj_002 && !obj_003)
                {
                    if (global_timer <= 3600)
                    {
                        obj_003 = true;
                        key_001 = true;
                    }
                }

                break;

            case "winner":

                if (key_001)
                {Application.LoadLevel("first_test");}
                
                break;
        }
	}
	
	void OnTriggerExit(Collider hit){
	
		if(hit.name == "igreja"){
		
			igreja = false;
		}
	}
	
	void Update(){
	
		global_timer = GameObject.Find("globalTime").GetComponent<GlobalTime>().globalTimer;
		
		
		if(key_001){
			
			GameObject.FindWithTag("barrier").collider.enabled = false;
		}
	}
	
}
