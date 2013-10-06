using UnityEngine;
using System.Collections;

public class DisableObject : MonoBehaviour {
	
	public MonoBehaviour[] scriptComponents;
	public float speedNavMesh;
	
	void Awake() {
		
		scriptComponents = GetComponents<MonoBehaviour>();
		
		if(GetComponent<NavMeshAgent>()){
			speedNavMesh = gameObject.GetComponent<NavMeshAgent>().speed;
		}
	}
	
	public void disableAll (bool disableTime) {

        if (!disableTime)
        {	
			gameObject.GetComponent<NavMeshAgent>().speed = 0;
			
			foreach(MonoBehaviour script in scriptComponents) {

                if (script == gameObject.GetComponent<DisableObject>())
                {
                    continue;
                }
                if (script == gameObject.GetComponent<NavMeshAgent>())
                {
                    continue;
                }
				
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