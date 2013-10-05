using UnityEngine;
using System.Collections;

public class itweenMovement : MonoBehaviour {
	
	public GameObject[] camPositions;
	public float timeDelay;
	private float currentTargetX;
	private float currentTargetY;
	private int currentTarget = 0;
	
	// Use this for initialization
	void Start (){
		moveCam();
	}
	
	// Update is called once per frame
	void Update () {
	}
		
	void moveCam(){
		print("--MOVING CAMERA--");
		if(currentTarget < camPositions.Length - 1){
		currentTarget++;
		currentTargetX = camPositions[currentTarget].transform.position.x;
		currentTargetY = camPositions[currentTarget].transform.position.y;
		iTween.MoveTo(gameObject,iTween.Hash("position",new Vector3(currentTargetX,currentTargetY,gameObject.transform.position.z),"time",5f,"oncomplete","moveCam"));}
	}
}
