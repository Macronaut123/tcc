using UnityEngine;
using System.Collections;

public class AnimatorControl : MonoBehaviour {

    private Animator animControl;
    public bool Anim1;
    public bool Anim2;
    public bool Anim3;
    public bool Anim4;


	// Use this for initialization
	void Start () {
        animControl = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Anim1) {
            animControl.SetBool("Idle", false);
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

    void OnGUI() { 
        if (GUI.Button(new Rect(40,40,130,20),"IDLE")){ Anim1 = true; Anim2 = false; Anim3 = false; Anim4 = false; }
        if (GUI.Button(new Rect(40, 60, 130, 20), "ANDANDO")) { Anim1 = false; Anim2 = true; Anim3 = false; Anim4 = false; }
        if (GUI.Button(new Rect(40, 80, 130, 20), "FALANDO NORMAL")) { Anim1 = false; Anim2 = false; Anim3 = true; Anim4 = false; }
        if (GUI.Button(new Rect(40, 100, 130, 20), "CORRENDO")) { Anim1 = false; Anim2 = false; Anim3 = false; Anim4 = true; }
    }
}
