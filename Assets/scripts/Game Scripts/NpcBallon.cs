using UnityEngine;
using System.Collections;

public class NpcBallon : MonoBehaviour {

	public bool showBallon = false;
	
	// Update is called once per frame
	
	public void Start(){
		gameObject.renderer.enabled = false;
	}
	
	public void show(bool _show){
		gameObject.renderer.enabled = _show;
	}
}