using UnityEngine;
using System.Collections;

public class NPC_Test : MonoBehaviour {

    private GameObject TargetObject;

    private int age;
    private string name;
    private string subinfo;
    private string description;
    private int[] dailyRoutine;
    private bool[] dailyRoutineCondition;

    private int TargetID;


    private bool showDescription;

	// Use this for initialization
	void Start () {

        TargetObject = GameObject.FindGameObjectWithTag("NPC_armazem");

        print("Idade do Objeto: " + TargetObject.GetComponent<NPC_Info>().age);
        print("Nome do Objeto: " + TargetObject.GetComponent<NPC_Info>().name);
        print("Classe do Objeto: " + TargetObject.GetComponent<NPC_Info>().subinfo);
        print("Descrição do Objeto: " + TargetObject.GetComponent<NPC_Info>().description);


        age = TargetObject.GetComponent<NPC_Info>().age;
        name = TargetObject.GetComponent<NPC_Info>().name;
        subinfo = TargetObject.GetComponent<NPC_Info>().subinfo;
        description = TargetObject.GetComponent<NPC_Info>().description;
        dailyRoutine = TargetObject.GetComponent<NPC_Info>().dailyRoutine;
        dailyRoutineCondition = TargetObject.GetComponent<NPC_Info>().dailyRoutineCondition;

        showDescription = false;
	}
	
	// Update is called once per frame
	void Update () {

        switch (TargetID){
            case 1:
                TargetObject = GameObject.FindGameObjectWithTag("NPC_armazem");
                break;
            case 2:
                TargetObject = GameObject.FindGameObjectWithTag("NPC_guardaforte");
                break;
        }

        age = TargetObject.GetComponent<NPC_Info>().age;
        name = TargetObject.GetComponent<NPC_Info>().name;
        subinfo = TargetObject.GetComponent<NPC_Info>().subinfo;
        description = TargetObject.GetComponent<NPC_Info>().description;
        dailyRoutine = TargetObject.GetComponent<NPC_Info>().dailyRoutine;
        dailyRoutineCondition = TargetObject.GetComponent<NPC_Info>().dailyRoutineCondition;
	
	}

    void OnGUI(){

        GUI.skin.box.wordWrap = true;
		
		if(GUI.Button(new Rect(40,550,180,30),"GUARDA")){
			TargetID = 2;
			if(showDescription){showDescription = false;} else {showDescription = true;}
		}
		
		if(GUI.Button(new Rect(40,580,180,30),"TAVERNEIRO")){
			TargetID = 1;
			if(showDescription){showDescription = false;} else {showDescription = true;}
		}
		
        if (showDescription){
            GUI.Box(new Rect(40, 40, 350, 150), "\nIdade: " + age + "\nNome: " + name + "\nClasse: " + subinfo + "\nDescrição: " + description);
            GUI.Box(new Rect(440, 15, 80, 275), "");
            for (int i = 0; i < dailyRoutine.Length; i++) {
                if (dailyRoutineCondition[i]){
                    GUI.Label(new Rect(450, 40 * i + 20, 180, 20), "Horário: " + dailyRoutine[i].ToString()); 
                }
            }
        }
    }
}
