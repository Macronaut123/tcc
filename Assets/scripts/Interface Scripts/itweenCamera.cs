using UnityEngine;
using System.Collections;

public class itweenCamera : MonoBehaviour {
	
	public float timeDelay;
	public GameObject targetCam;
	
	// Use this for initialization
	void Start () {
		iTween.MoveTo(gameObject,new Vector3(targetCam.transform.position.x,targetCam.transform.position.y,gameObject.transform.position.z),timeDelay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
