using UnityEngine;
using System.Collections;

public class TitorAnimation : MonoBehaviour {

    public Animation animControl;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
            animControl.CrossFade("Andando");
        }
        else{
            animControl.CrossFade("Idle");
        }
	}
}
