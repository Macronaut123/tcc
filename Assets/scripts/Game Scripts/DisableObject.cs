using UnityEngine;
using System.Collections;

public class DisableObject : GenericFunction {
	
	public MonoBehaviour[] scriptComponents;
	public float speedNavMesh;
	
	
	
	void Awake() {
		
		scriptComponents = GetComponents<MonoBehaviour>();
		
		if(GetComponent<NavMeshAgent>()){
			speedNavMesh = gameObject.GetComponent<NavMeshAgent>().speed;
		}
	}
	
	void Update () {

        if (!disableTime())
        {
			
			foreach(MonoBehaviour script in scriptComponents) {

                if (script == gameObject.GetComponent<DisableObject>())
                {
                    continue;
                }
                if (script == gameObject.GetComponent<NavMeshAgent>())
                {
                    continue;
                }
                /*
                if (script == gameObject.GetComponent<NpcSystemTalk>())
                {
                    continue;
                }
                if (script == gameObject.GetComponent<NpcSystemTalkSolo>())
                {
                    continue;
                }
                if (script == gameObject.GetComponent<NpcSystemTalkTwoActions>())
                {
                    continue;
                }
                if (script == gameObject.GetComponent<SpeechBubble>())
                {
                    continue;
                }
                */
                script.enabled = false;
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