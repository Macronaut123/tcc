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

        if (Input.GetKeyDown("u")) { if (showDescription) { showDescription = false; } else { showDescription = true; } }

        if (Input.GetKeyDown("i")) { TargetID = 1; print(TargetID); }
        if (Input.GetKeyDown("o")) { TargetID = 2; print(TargetID); }

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

        if (showDescription){
            GUI.Box(new Rect(40, 40, 350, 150), "\nIdade: " + age + "\nNome: " + name + "\nClasse: " + subinfo + "\nDescrição: " + description);
            GUI.Box(new Rect(440, 15, 80, 275), "");
            for (int i = 0; i < dailyRoutine.Length; i++) {
                if (dailyRoutineCondition[i]){
                    GUI.Label(new Rect(450, 40 * i + 20, 180, 20), "Horário: " + dailyRoutine[i].ToString()); 
                }
            }
        }

        
        GUI.Label(new Rect(Screen.width/2 - 150,Screen.height - 100,300,30),"Aperte U para abrir a tela de descrições");
    }
}
