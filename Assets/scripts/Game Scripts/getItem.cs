using UnityEngine;
using System.Collections;

public class GetItem : MonoBehaviour {
	
	private string itemName;
	
	void OnTriggerEnter(Collider hit){

        if(hit.gameObject.tag == "getable"){
			
			hit.gameObject.renderer.enabled = false;
			hit.gameObject.collider.enabled = false;
			
			var dp = GameObject.Find("Player").GetComponent<NpcObjectives>().dependencyActions;
			
			switch (hit.gameObject.name){
					
				case "letter":
					dp["letter_condition"] = true;	
				break;
				
				case "colar":
					dp["colar_condition"] = true;	
				break;
			}
        }
	}
}
