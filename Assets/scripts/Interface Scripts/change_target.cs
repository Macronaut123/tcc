using UnityEngine;
using System.Collections;

public class change_target : MonoBehaviour {

    private exSpriteBorder local_btn;
    public exSpriteFont text_to_change;
    public exSpriteFont[] hours_to_change;
    public GameObject new_target;
    public GameObject[] menus_to_show;
	public Vector3[] placetoGo;
	public float timeDelay;

    private int age;
    private string name;
    private string subinfo;
    private string[] description;
    private int[] dailySettings;
    private bool[] dailyConditions;

	// Use this for initialization
	void Start () {
        local_btn = gameObject.GetComponent<exSpriteBorder>();

        age = new_target.GetComponent<NpcInfo>().age;
        name = new_target.GetComponent<NpcInfo>().name;
        subinfo = new_target.GetComponent<NpcInfo>().subinfo;
        dailySettings = new_target.GetComponent<NpcInfo>().dailyRoutine;
        dailyConditions = new_target.GetComponent<NpcInfo>().dailyRoutineCondition;

        description = new string[2];
        description[0] = "Este � o primeiro \nvalor.";
        description[1] = "Este � o segundo \nvalor.";
		
		firstSetup();
	}

    void OnMouseDown() {
        if (menus_to_show != null)
        {
            for(int i=0; i < menus_to_show.Length; i++){
				iTween.MoveTo(menus_to_show[i],placetoGo[i],timeDelay);
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
	
	void firstSetup(){
		text_to_change.text = "\nIdade: " + age.ToString() +"\nNome: " + name + "\nClasse: " + subinfo + "\nDescricao: " + description[0];
        for (int o = 0; o < dailySettings.Length; o++) {
            if (dailyConditions[o]){
                hours_to_change[o].text = "Horario: " + dailySettings[o].ToString();}
            else{
                hours_to_change[o].text = "";}
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
