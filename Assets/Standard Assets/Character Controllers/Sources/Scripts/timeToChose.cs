using UnityEngine;
using System.Collections;

public class timeToChose : MonoBehaviour {
	
	public GameObject armaz;
	
	void Update(){
		
		
	}
	
	void OnGUI(){
		
		GUI.Label(new Rect(1000,10,100,20), "Voltar no tempo:");
		
		GUI.Box(new Rect(1000,40,40,20), "1");
		
		GUI.Box(new Rect(1000,60,60,20), "2");
		
		GUI.Box(new Rect(1000,80,80,20), "3");
		
		GUI.Box(new Rect(1000,100,100,20), "4");
		
	}
		
}
