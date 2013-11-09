using UnityEngine;
using System.Collections;

public class RayCastToTalk : MonoBehaviour {
	
	public bool canCheckRay = false;
	
	public void OnTriggerEnter(Collider hit){
		if(hit.name.Contains("NPC") && hit.tag == "canBack"){
			canCheckRay = true;
		}
	}
	
	public void OnTriggerExit(Collider hit){
		if(hit.name.Contains("NPC") && hit.tag == "canBack"){
			canCheckRay = false;
			if(hit.GetComponent<DemoAI>()){
				hit.GetComponent<DemoAI>().talking = false;
				hit.GetComponent<DemoAI>().setDisableTime(true);
				hit.GetComponent<DemoAI>().gameObject.GetComponent<DisableObject>().disableAll(true);
			}
		}
	}
	
	public void Update(){

		if(canCheckRay){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		    Debug.DrawRay(ray.origin, ray.direction * 10, Color.green);
			RaycastHit rayHit;
			if (Physics.Raycast (ray, out rayHit, 100)) {
				if(rayHit.collider.gameObject.name.Contains("NPC") && rayHit.collider.gameObject.tag == "canBack"){
					//Debug.Log(rayHit.collider.gameObject.name);
					if(Input.GetMouseButtonUp(0)){
						rayHit.collider.gameObject.GetComponent<SystemTalk>().enabled = true;
						rayHit.collider.gameObject.GetComponent<SystemTalk>().startFromHere();
						rayHit.collider.gameObject.GetComponent<SystemTalk>().a();
					}
				}
			}	
		}
	}
}
