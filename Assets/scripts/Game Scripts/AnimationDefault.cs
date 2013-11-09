using UnityEngine;
using System.Collections;

public class AnimationDefault : MonoBehaviour {

    public Animation animControl;
    private float currentSpeed;

	// Use this for initialization
	void Start () {
		var a = gameObject.name;
		char[] d = new char[] {'_'};
		var b = a.Split (d);
		//animControl = GameObject.Find(b[1]).animation;
		animControl = GameObject.Find("Persival").animation;
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
