using UnityEngine;
using System.Collections;

public class NPC_Test : MonoBehaviour {

    public GameObject TargetObject;

    private int age;
    private string name;
    private string subinfo;
    private string description;

    private bool showDescription;

	// Use this for initialization
	void Start () {

        print("Idade do Objeto: " + TargetObject.GetComponent<NPC_Info>().age);
        print("Nome do Objeto: " + TargetObject.GetComponent<NPC_Info>().name);
        print("Classe do Objeto: " + TargetObject.GetComponent<NPC_Info>().subinfo);
        print("Descrição do Objeto: " + TargetObject.GetComponent<NPC_Info>().description);


        age = TargetObject.GetComponent<NPC_Info>().age;
        name = TargetObject.GetComponent<NPC_Info>().name;
        subinfo = TargetObject.GetComponent<NPC_Info>().subinfo;
        description = TargetObject.GetComponent<NPC_Info>().description;

        showDescription = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("u")) { if (showDescription) { showDescription = false; } else { showDescription = true; } }
	
	}

    void OnGUI(){

        if (showDescription) { GUI.Box(new Rect(40, 40, 400, 100), "\nIdade: " + age + "\nNome: " + name + "\nClasse: " + subinfo + "\nDescrição: " + description); }
        
        GUI.Label(new Rect(Screen.width/2 - 150,Screen.height - 100,300,30),"Aperte U para abrir a tela de descrições");
    }
}
