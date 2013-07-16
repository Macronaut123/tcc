using UnityEngine;
using System.Collections;

public class interact : MonoBehaviour {
	
	public float global_time;
	public string speak = "";
	public bool armazem_stay = false;
	public bool manto_on = false;
	public bool igreja = false;
	public string localization = "";
	
	void OnTriggerEnter(Collider hit){

        switch (hit.gameObject.name){
            case "igreja":
                igreja = true;
			    localization = "Igreja";
                break;
            case "NPC_armazem":
                if (global_time > 180) { speak = "So posso abrir o Armazem as 3h"; localization = "Casa"; }
                if (global_time < 180 && global_time > 120) { speak = "So posso abrir o Armazem as 3h"; localization = "Mercado"; manto_on = true; }
                if (global_time < 120 && global_time > 60) { speak = "Aqui esta seu manto, jogador obtem manto"; localization = "Armazem"; manto_on = true; }
                if (global_time > 60) { speak = "Aqui esta seu manto, jogador obtem manto"; localization = "Armazem"; manto_on = true; }
                else { }
                break;
            case "NPC_GUARDA":
                if (global_time > 180) { speak = "O rei nao esta atendendo no momento."; }
                if (global_time < 180 && global_time > 120) { if (!manto_on) { speak = "So os que possuem o manto podem entrar"; } else {   speak = "Por favor, sinta-se a vontade"; GameObject.Find("block").collider.enabled = false; } }
                if (global_time < 120 && global_time > 60) { speak = "O rei nao esta atendendo no momento"; }
                if (global_time > 60) { speak = "O rei nao esta atendendo no momento"; }
                else { }
                break;
            case "NPC_rei":
                speak = "Parabens, você conseguiu";
                break;
            case "Armazem_trigger":
                if (hit.gameObject.name == "Armazem_trigger") { armazem_stay = true; } else { armazem_stay = false; }
                break;
        }
		
			speak = "Parabens, você conseguiu";
		
		}
		
		/*
		if(hit.gameObject.name == "Armazem_trigger"){
			
			armazem_stay = true;
		}else{
		
			armazem_stay = false;
		}*/
	
	void OnTriggerExit(Collider hit){

        switch (hit.gameObject.name) { 
            case "igreja":
                igreja = false;
                break;
            case "NPC_armazem":
                speak = "";
                break;
            case "NPC_GUARDA":
                speak = "";
                break;
            case "NPC_rei":
                speak = "";
                break;
        }
		
	}
	
	
	void OnGUI(){
		
		GUI.Label(new Rect(10,50,200,200), speak);
		
	}
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		global_time = GameObject.Find("globalTime").GetComponent<globalTIME>().global_timer;
	
	}
}
