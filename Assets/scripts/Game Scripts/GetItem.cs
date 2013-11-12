using UnityEngine;
using System.Collections;

public class GetItem : MonoBehaviour {
	
	private string itemName;
	
	void OnTriggerEnter(Collider hit){

        if(hit.gameObject.tag == "getable"){
			hit.gameObject.SetActive(false);
			var playerDependency = GameObject.Find("Player").GetComponent<NpcObjectives>().dependencyActions;
			playerDependency[hit.gameObject.name] = true;	
        }
	}
}
