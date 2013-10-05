using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed = 1f;
	public float turnSpeed = 0.5f;
	
	//A simple movement script
	void FixedUpdate(){
		transform.Translate( Vector3.forward * Input.GetAxis("Vertical") * speed );
		transform.RotateAround( Vector3.up, Input.GetAxis("Horizontal") * turnSpeed );
	}
}
