using UnityEngine;
using System.Collections;

public class getItem : MonoBehaviour {
	
	private string itemName;
	
	void OnTriggerEnter(Collider hit){

        if(hit.gameObject.tag == "getable"){
			
			hit.gameObject.renderer.enabled = false;
			hit.gameObject.collider.enabled = false;
        }
	}
}
