using UnityEngine;
using System.Collections;

public class PopupManage : MonoBehaviour {
	
	public UILabel textChange;
	public UILabel[] horarios;
	
	private UIPopupList controlPop;
	private bool[] Conditions;
	private int[] Hours;
	private GameObject infoChange;
	
	// Use this for initialization
	void Start () {
		
		controlPop = gameObject.GetComponent<UIPopupList>();
        EventDelegate.Set(controlPop.onChange, CheckSelection);

        for (var i = 0; i < horarios.Length; i++)
        {
            horarios[i].text = "";
        }
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void CheckSelection(){

        

		switch(controlPop.value){
			case "NPCs":
			for(int i = 0; i < horarios.Length; i++){horarios[i].text = "";}
			textChange.text = "Nenhum NPC selecionado.";
			break;
            case "Anika":
            infoChange = GameObject.Find("NPC_Anika");
            Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
            Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
            textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
            for (var i = 0; i < Conditions.Length; i++)
            {
                if (Conditions[i] == true)
                {
                    horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i] + 1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
                }
            }
            break;
			case "Drake":
			infoChange = GameObject.Find("NPC_Drake");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Klaus":
			infoChange = GameObject.Find("NPC_Klaus");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Persival":
			infoChange = GameObject.Find("NPC_Persival");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Tobbie":
			infoChange = GameObject.Find("NPC_Tobbie");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Ulric":
			infoChange = GameObject.Find("NPC_Ulric");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Benn":
			infoChange = GameObject.Find("NPC_Benn");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Aina":
			infoChange = GameObject.Find("NPC_Aina");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Alvis":
			infoChange = GameObject.Find("NPC_Alvis");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Argus":
			infoChange = GameObject.Find("NPC_Argus");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Finn":
			infoChange = GameObject.Find("NPC_Finn");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Gunvar":
			infoChange = GameObject.Find("NPC_Gunvar");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Rikki":
			infoChange = GameObject.Find("NPC_Rikki");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
			case "Encapuzado":
			infoChange = GameObject.Find("NPC_Encapuzado");
			Conditions = infoChange.GetComponent<NpcInfo>().dailyRoutineCondition;
			Hours = infoChange.GetComponent<NpcInfo>().dailyRoutine;
			textChange.text = "Nome = " + infoChange.GetComponent<NpcInfo>().name + "\nIdade = " + infoChange.GetComponent<NpcInfo>().age.ToString() + "\nClasse = " + infoChange.GetComponent<NpcInfo>().subinfo + "\nResumo = " + infoChange.GetComponent<NpcInfo>().description;
			for(var i = 0; i < Conditions.Length; i++){
				if(Conditions[i] == true){
					horarios[i].text = "Entre " + Hours[i].ToString() + "h e " + (Hours[i]+1).ToString() + "h no local " + PlayerCollides.CollisionName + ".";
				}
			}
				break;
		}
	}
}
