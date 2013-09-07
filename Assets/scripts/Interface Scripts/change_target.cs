using UnityEngine;
using System.Collections;

public class change_target : MonoBehaviour {

    private exSpriteBorder local_btn;
    public exSpriteFont text_to_change;
    public exSpriteFont[] hours_to_change;
    public GameObject new_target;
    public GameObject[] menus_open;

    private int age;
    private string name;
    private string subinfo;
    private string[] description;
    private int[] dailySettings;
    private bool[] dailyConditions;

	// Use this for initialization
	void Start () {
        local_btn = gameObject.GetComponent<exSpriteBorder>();

        age = new_target.GetComponent<NPC_Info>().age;
        name = new_target.GetComponent<NPC_Info>().name;
        subinfo = new_target.GetComponent<NPC_Info>().subinfo;
        dailySettings = new_target.GetComponent<NPC_Info>().dailyRoutine;
        dailyConditions = new_target.GetComponent<NPC_Info>().dailyRoutineCondition;

        description = new string[2];
        description[0] = "Este é o primeiro \nvalor.";
        description[1] = "Este é o segundo \nvalor.";
	}

    void OnMouseDown() {
        if (menus_open != null)
        {
            for (int i = 0; i < menus_open.Length; i++)
            {
                menus_open[i].SetActive(true);
            }
        }

        text_to_change.text = "\nIdade: " + age.ToString() +"\nNome: " + name + "\nClasse: " + subinfo + "\nDescricao: " + description[0];
        for (int o = 0; o < dailySettings.Length; o++) {
            if (dailyConditions[o])
                hours_to_change[o].text = "Horario: " + dailySettings[o].ToString();
            else
                hours_to_change[o].text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
	    
	}

    void OnMouseOver(){
        local_btn.color = Color.green;
    }

    void OnMouseExit(){
        local_btn.color = Color.white;
    }
}
