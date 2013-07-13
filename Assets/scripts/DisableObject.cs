using UnityEngine;
using System.Collections;

public class DisableObject : MonoBehaviour {
	
	public MonoBehaviour[] scriptComponents;
	public float speedNavMesh;
	private bool Disenable;
	
	
	
	void Awake() {
		
		scriptComponents = GetComponents<MonoBehaviour>();
		
		if(GetComponent<NavMeshAgent>()){
			speedNavMesh = gameObject.GetComponent<NavMeshAgent>().speed;
		}
	}
	
	void Update () {
		
		Disenable = GameObject.Find("globalTime").GetComponent<globalTIME>().Disenable;
		
		if(!Disenable){
			
			foreach(MonoBehaviour script in scriptComponents) {
    	
				if(GetComponent<NavMeshAgent>()){
					gameObject.GetComponent<NavMeshAgent>().speed = 0;	
				}
				
				script.enabled = false;
				gameObject.GetComponent<DisableObject>().enabled = true;
				
				if(GetComponent<NPC_systemTalk>()){
					GetComponent<NPC_systemTalk>().enabled = true;
				}
				if(GetComponent<SpeechBubble>()){
					GetComponent<SpeechBubble>().enabled = true;
				}
			}
			
		}else{
			foreach(MonoBehaviour script in scriptComponents) {
	    		script.enabled = true;
				if(GetComponent<NavMeshAgent>()){
					gameObject.GetComponent<NavMeshAgent>().speed = speedNavMesh;
				}
			}
		}
	}
}
