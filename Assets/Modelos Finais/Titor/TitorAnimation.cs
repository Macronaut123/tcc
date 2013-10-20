using UnityEngine;
using System.Collections;

public class TitorAnimation : MonoBehaviour {

    public Animator animControl;
    public bool Anim1;
    public bool Anim2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Anim1) { animControl.SetBool("Idle", true); animControl.SetBool("Andando", false); }
        if (Anim2) { animControl.SetBool("Idle", false); animControl.SetBool("Andando", true); }
	}
}
