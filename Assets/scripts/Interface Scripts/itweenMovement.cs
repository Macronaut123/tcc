using UnityEngine;
using System.Collections;

public class itweenMovement : MonoBehaviour {

	// Use this for initialization
	void Start (){
	}
	
	// Update is called once per frame
	void Update () {
        iTween.MoveTo(gameObject, iTween.Hash("position", new Vector3(39, -1), "easetype", iTween.EaseType.linear,"time",20f));
	}
}
