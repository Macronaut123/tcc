using UnityEngine;
using System.Collections;

public class Aina : MonoBehaviour {

    public Animation animControl;
    private float currentSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        currentSpeed = gameObject.GetComponent<AiBasic>().direction.magnitude;

        

        if (currentSpeed > 3)
        {
            animControl.CrossFade("Andando");
        }
        else
        {
            animControl.CrossFade("Idle");
        }

	}
}
