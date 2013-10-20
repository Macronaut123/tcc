using UnityEngine;
using System.Collections;

public class UlricAnimation : MonoBehaviour {

    public Animator animControl;
    private float currentSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        currentSpeed = gameObject.GetComponent<AiBasic>().direction.magnitude;
        animControl.SetFloat("Speed", currentSpeed);

	}
}
