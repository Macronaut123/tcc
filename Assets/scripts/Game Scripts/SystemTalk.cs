using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SystemTalk : GenericFunction {
	
	public GameObject addPopup;
	public int[] daily;
	public bool[] dailyCond;
	
	public void OnTriggerEnter(Collider hit){

        if (hit.name == "Player"){
			
			int h = 0;
			int m = 0;
			var npcInDependency = false;

			h = hour();
			m = minut();

            switch (gameObject.name) { 
                case "NPC_Drake":
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Drake")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Drake");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
					break;
                case "NPC_Klaus":
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Klaus")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Klaus");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Persival":             
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Persival")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Persival");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Tobbie":
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Tobbie")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Tobbie");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Ulric":  
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Ulric")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Ulric");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Benn":                 
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Benn")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Benn");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Aina":
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Aina")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Aina");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
					break;
                case "NPC_Alvis":                    
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Alvis")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Alvis");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Argus":                    
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Argus")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Argus");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Finn":                
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Finn")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Finn");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Gunvar":                    
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Gunvar")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Gunvar");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Rikki":                    
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Rikki")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Rikki");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Encapuzado":                    
				daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
				dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
				if(!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Encapuzado")){
				addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Encapuzado");}
				for(int i = 0; i < daily.Length; i++){
					if(daily[i] == h){
						dailyCond[i] = true;
					}
				}
                    break;
                case "NPC_Anika":
                    daily = gameObject.GetComponent<NpcInfo>().dailyRoutine;
                    dailyCond = gameObject.GetComponent<NpcInfo>().dailyRoutineCondition;
                    if (!addPopup.gameObject.GetComponent<UIPopupList>().items.Contains("Anika"))
                    {
                        addPopup.gameObject.GetComponent<UIPopupList>().items.Add("Anika");
                    }
                    for (int i = 0; i < daily.Length; i++)
                    {
                        if (daily[i] == h)
                        {
                            dailyCond[i] = true;
                        }
                    }
                    break;
            }
			
			//NPC COM DEPENDENCIA
            switch (gameObject.name)
            {
				/*
                case "NPC_Aina" :

                    if(h == 6 && m < 30){
						engineSystemTalk("0600", "player_knowledge_to_got_churchkey");
			        }

                    else if (h == 6 && m >= 30)
                    {
						engineSystemTalk("0630", "player_knowledge_to_got_churchkey");
                    }
				
                    npcInDependency = true;
				
                break;
				
				
                case "NPC_Alviss":

                    if (h == 6 && m < 30)
                    {
						engineSystemTalk("0600", "player_knowledge_to_got_churchkey");
						engineSystemTalk("0600", "player_got_churchkey");
                    }
				
                    npcInDependency = true;
				
                break;
                */
				
            }
			
            if (npcInDependency)
            {
                return;
            }
			
			#region NPC SEM DEPENDENCIA
            if (h == 6 && m < 30)
            {
                makeValidateForSimpleNpc("0600");
            }
            else if (h == 6 && m >= 30)
            {
                makeValidateForSimpleNpc("0630");
            }
            else if (h == 7 && m < 30)
            {
                makeValidateForSimpleNpc("0700");
            }

            else if (h == 7 && m >= 30)
            {
                makeValidateForSimpleNpc("0730");
            }

            else if (h == 8 && m < 30)
            {
                makeValidateForSimpleNpc("0800");
            }

            else if (h == 8 && m >= 30)
            {
                makeValidateForSimpleNpc("0830");
            }

            else if (h == 9 && m < 30)
            {
                makeValidateForSimpleNpc("0900");
            }

            else if (h == 9 && m >= 30)
            {
                makeValidateForSimpleNpc("0930");
            }
            else if (h == 10 && m < 30)
            {
                makeValidateForSimpleNpc("1000");
            }

            else if (h == 10 && m >= 30)
            {
                makeValidateForSimpleNpc("1030");
            }
            else if (h == 11 && m < 30)
            {
                makeValidateForSimpleNpc("1100");
            }

            else if (h == 11 && m >= 30)
            {
                makeValidateForSimpleNpc("1130");
            }
            else if (h == 12 && m < 30)
            {
                makeValidateForSimpleNpc("1200");
            }

            else if (h == 12 && m >= 30)
            {
                makeValidateForSimpleNpc("1230");
            }
            else if (h == 13 && m < 30)
            {
                makeValidateForSimpleNpc("1300");
            }

            else if (h == 14 && m >= 30)
            {
                makeValidateForSimpleNpc("1430");
            }
            else if (h == 15 && m < 30)
            {
                makeValidateForSimpleNpc("1500");
            }

            else if (h == 15 && m >= 30)
            {
                makeValidateForSimpleNpc("1530");
            }
            else if (h == 16 && m < 30)
            {
                makeValidateForSimpleNpc("1600");
            }

            else if (h == 16 && m >= 30)
            {
                makeValidateForSimpleNpc("1630");
            }
            else if (h == 17 && m < 30)
            {
                makeValidateForSimpleNpc("1700");
            }

            else if (h == 17 && m >= 30)
            {
                makeValidateForSimpleNpc("1730");
            }
            else if (h == 18 && m < 30)
            {
                makeValidateForSimpleNpc("1800");
            }

            else if (h == 18 && m >= 30)
            {
                makeValidateForSimpleNpc("1830");
            }
            else if (h == 19 && m < 30)
            {
                makeValidateForSimpleNpc("1900");
            }

            else if (h == 19 && m >= 30)
            {
                makeValidateForSimpleNpc("1930");
            }
            else if (h == 20 && m < 30)
            {
                makeValidateForSimpleNpc("2000");
            }

            else if (h == 20 && m >= 30)
            {
                makeValidateForSimpleNpc("2030");
            }
            else if (h == 21 && m < 30)
            {
                makeValidateForSimpleNpc("2100");
            }

            else if (h == 21 && m >= 30)
            {
                makeValidateForSimpleNpc("2130");
            }
            else if (h == 22 && m < 30)
            {
                makeValidateForSimpleNpc("2200");
            }
			
			#endregion
		}
	}
		
	public void engineSystemTalk(string time, string dependency){
			ValidateDependency(time, MakeValidateForDependencyNpc(dependency));
	}
	
	public void ValidateDependency(string time, string file) {
		var fileName = gameObject.name+"/"+gameObject.name+"_"+time;
		if(file != ""){
			fileName = fileName+"_"+file;
		}
		validateLifeTime(time, fileName, true);
	}
	
	public string MakeValidateForDependencyNpc(string dependency) {
		
		if(getDependency(gameObject , dependency , true)){
			return dependency;
		}else{
			return "";
		}
	}
	
	public void makeValidateForSimpleNpc(string key){
	    var fileName = gameObject.name + "/" + gameObject.name + "_" + key;
	    var newValue = true;
	    validateLifeTime(key, fileName, newValue);
	}
	
	public void validateLifeTime(string time, string fileName, bool newValue){
		
		if(gameObject.GetComponent<LifeTime>().getLifeTimeValue(time) != newValue){
			gameObject.GetComponent<LifeTime>().setLifeTimeValue(time, newValue);
		}
		if(!gameObject.GetComponent<DemoAI>()){
			gameObject.AddComponent<DemoAI>().setFileName(fileName);
		}else{
			gameObject.GetComponent<DemoAI>().setFileName(fileName);
		}
	}
}