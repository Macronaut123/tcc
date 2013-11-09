using UnityEngine;
using System.Collections;

public class AnimationPlayer : MonoBehaviour {
	
	public Animation animControl;
    private float currentSpeed;
	
	void Start () {
		animControl.CrossFade("Idle");
	}
	
	public bool keyD(KeyCode k){
		return Input.GetKeyDown(k);
	}
	
	public bool keyU(KeyCode k){
		return Input.GetKeyUp(k);
	}
	
	void Update () {
		
		if(keyD(KeyCode.W)){
			animControl.CrossFade("Andando");
		}
		
		if(keyU(KeyCode.W)){
			animControl.CrossFade("Idle");
		}
	}
}
