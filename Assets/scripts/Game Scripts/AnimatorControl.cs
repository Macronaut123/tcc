using UnityEngine;
using System.Collections;

public class AnimatorControl : MonoBehaviour {

    public Animator animControl;
    public bool Anim1;
    public bool Anim2;
    public bool Anim3;
    public bool Anim4;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Anim1) {
            animControl.SetBool("Idle", true);
            animControl.SetBool("Andando", false);
            animControl.SetBool("FalandoNormal", false);
            animControl.SetBool("Correndo", false);
        }

        if (Anim2)
        {
            animControl.SetBool("Idle", false);
            animControl.SetBool("Andando", true);
            animControl.SetBool("FalandoNormal", false);
            animControl.SetBool("Correndo", false);
        }

        if (Anim3)
        {
            animControl.SetBool("Idle", false);
            animControl.SetBool("Andando", false);
            animControl.SetBool("FalandoNormal", true);
            animControl.SetBool("Correndo", false);
        }

        if (Anim4)
        {
            animControl.SetBool("Idle", false);
            animControl.SetBool("Andando", false);
            animControl.SetBool("FalandoNormal", false);
            animControl.SetBool("Correndo", true);
        }
    }
}
