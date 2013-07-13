using UnityEngine;
using System.Collections;

public class globalTIME : MonoBehaviour {
	
	
	public bool igreja;
	public float global_timer;
	
	public bool Disenable = true;
	
	
	void Update (){
	
		
		igreja = GameObject.Find("objetivo_001").GetComponent<objetivos_001>().igreja;
		
		//if(igreja){
		
			if(Input.GetKeyDown(KeyCode.Alpha0)){
				global_timer = 0f;
				
			}else if(Input.GetKeyDown(KeyCode.Alpha1)){
			
				global_timer = 3600f;
			
			}else if(Input.GetKeyDown(KeyCode.Alpha2)){
			
				global_timer = 7200f;
			
			}else if(Input.GetKeyDown(KeyCode.Alpha3)){
			
				global_timer = 10790;
			
			//}
		}
		
		if(Disenable){
			global_timer += Time.deltaTime;
		}
		
		if(global_timer >= 10800){
			
			Application.LoadLevel("first_test");
		}
			
	}
	
	
	
	string FormatSeconds(float elapsed){
		
	    float d = (elapsed * 100.0f);
	    float minutes = Mathf.Floor(d / (60 * 100));
	    float seconds = Mathf.Floor((d % (60 * 100)) / 100);
	    float hundredths = d % 100;
		
		float hours = Mathf.Floor(minutes / 60 );
		
		return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
	}
	
	void OnGUI(){
		
		GUI.Label(new Rect(10,10,150,50), FormatSeconds(global_timer));
		
	}
}
