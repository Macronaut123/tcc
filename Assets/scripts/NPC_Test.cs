using UnityEngine;
using System.Collections;

public class NPC_Test : MonoBehaviour {

    public GameObject TargetObject;

    private int age;
    private string name;
    private string subinfo;
    private string description;

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
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI(){

        GUI.Box(new Rect(40, 40, 400, 800), "Idade: " + age + "\nNome: " + name + "\nClasse: " + subinfo + "\nDescrição: " + description);
    }
}
