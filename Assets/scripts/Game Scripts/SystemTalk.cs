using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SystemTalk : GenericFunction {
	
	public void OnTriggerEnter(Collider hit){

        if (hit.name == "Player"){
			
			int h = 0;
			int m = 0;
			
			h = hour();
			m = minut();
			
			if(h == 6 && m < 30){
				var key = "0600";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 6 && m >= 30){
				var key = "0630";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 7 && m < 30){
				var key = "0700";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 7 && m >= 30){
				var key = "0730";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 8 && m < 30){
				var key = "0800";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 8 && m >= 30){
				var key = "0830";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 9 && m < 30){
				var key = "0900";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 9 && m >= 30){
				var key = "0930";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 10 && m < 30){
				var key = "1000";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 10 && m >= 30){
				var key = "1030";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 11 && m < 30){
				var key = "1100";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 11 && m >= 30){
				var key = "1130";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 12 && m < 30){
				var key = "1200";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 12 && m >= 30){
				var key = "1230";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 13 && m < 30){
				var key = "1300";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 14 && m >= 30){
				var key = "1430";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 15 && m < 30){
				var key = "1500";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 15 && m >= 30){
				var key = "1530";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 16 && m < 30){
				var key = "1600";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 16 && m >= 30){
				var key = "1630";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 17 && m < 30){
				var key = "1700";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 17 && m >= 30){
				var key = "1730";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 18 && m < 30){
				var key = "1800";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 18 && m >= 30){
				var key = "1830";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 19 && m < 30){
				var key = "1900";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 19 && m >= 30){
				var key = "1930";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 20 && m < 30){
				var key = "2000";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 20 && m >= 30){
				var key = "2030";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 21 && m < 30){
				var key = "2100";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			
			else if(h == 21 && m >= 30){
				var key = "2130";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
			else if(h == 22 && m < 30){
				var key = "2200";
				var fileName = gameObject.name+"/"+gameObject.name+"_"+key;
				var newValue = true;
				validateLifeTime(key, fileName, newValue);
			}
		}
	}
	
	public void validateLifeTime(string key, string fileName, bool newValue){
		
		if(gameObject.GetComponent<LifeTime>().getLifeTimeValue(key) != newValue){
			gameObject.GetComponent<LifeTime>().setLifeTimeValue(key, newValue);
		}
		if(!gameObject.GetComponent<DemoAI>()){
			gameObject.AddComponent<DemoAI>().setFileName(fileName);
		}else{
			gameObject.GetComponent<DemoAI>().setFileName(fileName);
		}
	}
}