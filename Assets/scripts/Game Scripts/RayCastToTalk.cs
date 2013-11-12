using UnityEngine;
using System.Collections;

public class RayCastToTalk : MonoBehaviour {
	
	public bool canCheckRay = false;
	public bool isRotating = false;
	public GameObject NpcToRotate;
	
	public void OnTriggerEnter(Collider hit){
		if(hit.name.Contains("NPC") && hit.tag == "canBack"){
			canCheckRay = true;
			GameObject.Find(hit.gameObject.name+"_Balao").GetComponent<NpcBallon>().show(true);
		}
	}
	
	public void OnTriggerExit(Collider hit){
		
		Debug.Log("TriggerExit");
		
		if(hit.name.Contains("NPC") && hit.tag == "canBack"){
			canCheckRay = false;
			if(hit.GetComponent<DemoAI>()){
				hit.GetComponent<DemoAI>().talking = false;
				hit.GetComponent<DemoAI>().setDisableTime(true);
				hit.GetComponent<DemoAI>().gameObject.GetComponent<DisableObject>().disableAll(true);
				isRotating = false;
			}
			GameObject.Find(hit.gameObject.name+"_Balao").GetComponent<NpcBallon>().show(false);
		}
	}
	
	public void Update(){
		
		RaycastHit rayHit;
		
		if(canCheckRay){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		    Debug.DrawRay(ray.origin, ray.direction * 10, Color.green);
			if (Physics.Raycast (ray, out rayHit, 100)) {
				if(rayHit.collider.gameObject.name.Contains("NPC") && rayHit.collider.gameObject.tag == "canBack"){
					if(Input.GetMouseButtonUp(0)){
						rayHit.collider.gameObject.GetComponent<SystemTalk>().enabled = true;
						rayHit.collider.gameObject.GetComponent<SystemTalk>().startFromHere();
						isRotating = true;
						NpcToRotate = rayHit.collider.gameObject;
					}
				}
			}	
		}
		
		if(isRotating){
			NpcToRotate.transform.LookAt(gameObject.transform.position);
			NpcToRotate.transform.eulerAngles = new Vector3(0,NpcToRotate.transform.transform.eulerAngles.y , 0);
		}
	}
}
