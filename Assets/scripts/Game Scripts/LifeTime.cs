using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LifeTime : GenericFunction {
	
	public Dictionary<string ,bool> life;
	
	public void setLifeTimeValue(string key, bool newValue){
	
		life[key] = newValue;
		print(key + " " +life[key]);
	}
	
	public bool getLifeTimeValue(string key){
		return life[key];
	}
	
	public void Awake(){
	
		life = new Dictionary<string, bool>();
		
		life.Add("0600", false);
		life.Add("0630", false);
		
		life.Add("0700", false);
		life.Add("0730", false);
		
		life.Add("0800", false);
		life.Add("0830", false);
		
		life.Add("0900", false);
		life.Add("0930", false);
		
		life.Add("1000", false);
		life.Add("1030", false);
		
		life.Add("1100", false);
		life.Add("1130", false);
		
		life.Add("1200", false);
		life.Add("1230", false);
		
		life.Add("1300", false);
		life.Add("1330", false);
		
		life.Add("1400", false);
		life.Add("1430", false);
		
		life.Add("1500", false);
		life.Add("1530", false);
		
		life.Add("1600", false);
		life.Add("1630", false);
		
		life.Add("1700", false);
		life.Add("1730", false);
		
		life.Add("1800", false);
		life.Add("1830", false);
		
		life.Add("1900", false);
		life.Add("1930", false);
		
		life.Add("2000", false);
		life.Add("2030", false);
		
		life.Add("2100", false);
		life.Add("2130", false);
		
		life.Add("2200", false);
	}
	
}

