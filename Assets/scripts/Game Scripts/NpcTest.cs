using UnityEngine;
using System.Collections;

public class NpcTest : MonoBehaviour {

    private GameObject TargetObject;
    public static bool Armazem;
    public static bool Guarda;

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

        Guarda = false;
        Armazem = false;

        TargetObject = GameObject.FindGameObjectWithTag("NPC_armazem");

        age = TargetObject.GetComponent<NpcInfo>().age;
        name = TargetObject.GetComponent<NpcInfo>().name;
        subinfo = TargetObject.GetComponent<NpcInfo>().subinfo;
        description = TargetObject.GetComponent<NpcInfo>().description;
        dailyRoutine = TargetObject.GetComponent<NpcInfo>().dailyRoutine;
        dailyRoutineCondition = TargetObject.GetComponent<NpcInfo>().dailyRoutineCondition;

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

        age = TargetObject.GetComponent<NpcInfo>().age;
        name = TargetObject.GetComponent<NpcInfo>().name;
        subinfo = TargetObject.GetComponent<NpcInfo>().subinfo;
        description = TargetObject.GetComponent<NpcInfo>().description;
        dailyRoutine = TargetObject.GetComponent<NpcInfo>().dailyRoutine;
        dailyRoutineCondition = TargetObject.GetComponent<NpcInfo>().dailyRoutineCondition;
	
	}

    void OnGUI(){

        GUI.skin.box.wordWrap = true;

        if (Guarda)
        {
            if (GUI.Button(new Rect(40, 550, 180, 30), "GUARDA"))
            {
                TargetID = 2;
                if (showDescription) { showDescription = false; } else { showDescription = true; }
            }
        }

        if (Armazem)
        {
            if (GUI.Button(new Rect(40, 580, 180, 30), "TAVERNEIRO"))
            {
                TargetID = 1;
                if (showDescription) { showDescription = false; } else { showDescription = true; }
            }
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
