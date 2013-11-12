using UnityEngine;
using System.Collections;

public class GetItem : MonoBehaviour {
	
	void OnTriggerEnter(Collider hit){
		
        if(hit.gameObject.tag == "getable"){
			hit.gameObject.collider.enabled = false;
			hit.gameObject.renderer.enabled = false;
			var playerDependency = GameObject.Find("Player").GetComponent<NpcObjectives>().dependencyActions;
			if(playerDependency.ContainsKey(hit.gameObject.name)){
				playerDependency[hit.gameObject.name] = true;	
			}else{
				playerDependency.Add(hit.gameObject.name, true);
			}
        }
	}
}