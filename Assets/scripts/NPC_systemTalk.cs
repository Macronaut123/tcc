using UnityEngine;
using System.Collections;

public class NPC_systemTalk : MonoBehaviour {

	public string[] currentConversa;
	public string[] conversa_0;
	public string[] conversa_1;
	public string[] conversa_2;
	public string[] conversa_3;
	
	public bool talking;	
	public int currentLine;
	
	public string _talking;
	
	private float global_timer;
	
	public bool obj_001;
	public bool obj_002;
	public bool obj_003;
	
	public bool camDesactive = false;
	
	public bool Disenable;
	
	void Start(){
		
		currentLine = 1;
		
	}
	
	void OnTriggerEnter(Collider hit){
	
		if(hit.tag == "Player"){
			if(camDesactive){
				GameObject.Find("MiniMap").camera.enabled = false;
			}
			currentLine = 1;
			GetingTalk();
			talking = true;
			_talking = currentConversa[currentLine];
			GameObject.Find("globalTime").GetComponent<globalTIME>().Disenable = false;
		}
	}
	
	void OnTriggerExit(Collider hit){
	
		if(hit.tag == "Player"){
			if(camDesactive){
				GameObject.Find("MiniMap").camera.enabled = true;
			}
			talking = false;
			currentLine = 1;
			_talking = "";
			GameObject.Find("globalTime").GetComponent<globalTIME>().Disenable = true;
		}
	}
	
	void GetingTalk(){
		
		global_timer = GameObject.Find("globalTime").GetComponent<globalTIME>().global_timer;
		obj_001 = GameObject.Find("objetivo_001").GetComponent<objetivos_001>().obj_001;
		obj_002 = GameObject.Find("objetivo_001").GetComponent<objetivos_001>().obj_002;
		obj_003 = GameObject.Find("objetivo_001").GetComponent<objetivos_001>().obj_003;
		
		string[] checkConversa_0 = conversa_0[0].Split('/');
		string[] checkConversa_1 = conversa_1[0].Split('/');
		string[] checkConversa_2 = conversa_2[0].Split('/');
		string[] checkConversa_3 = conversa_3[0].Split('/');
		
		if(float.Parse(checkConversa_0[0]) <= global_timer && float.Parse(checkConversa_0[1]) >= global_timer){
			
			if(gameObject.name == "_NPC_Talker"){
				
				if(obj_003){
					currentConversa = conversa_2;
				}else{
					currentConversa = conversa_0;
				}
				
			}else if(gameObject.name == "NPC_guardaForte"){
				
				if(obj_002){
					currentConversa = conversa_2;
					gameObject.GetComponent<basicAI>().waypoints.Clear();
					gameObject.GetComponent<basicAI>().currentWayPoint = 0;
					gameObject.GetComponent<basicAI>().FindWayPoints();
				}else{
					currentConversa = conversa_1;
				}
				
			}else{
				currentConversa = conversa_0;
			}
			
		}else if(float.Parse(checkConversa_1[0]) <= global_timer && float.Parse(checkConversa_1[1]) >= global_timer){
			
			if(gameObject.name == "NPC_armazem"){
				
				if(obj_001){
					currentConversa = conversa_2;
				}else{
					currentConversa = conversa_1;
				}
				
			}else if(gameObject.name == "_NPC_Talker"){
				
				if(obj_003){
					currentConversa = conversa_2;
				}else{
					currentConversa = conversa_1;
				}
				
			}else{
				currentConversa = conversa_1;
			}
			
		}else if(float.Parse(checkConversa_2[0]) <= global_timer && float.Parse(checkConversa_2[1]) >= global_timer){
			
			currentConversa = conversa_2;
			
		}else if(float.Parse(checkConversa_3[0]) <= global_timer && float.Parse(checkConversa_3[1]) >= global_timer){
			
			if(gameObject.name == "_NPC_Talker"){
				
				if(obj_003){
					currentConversa = conversa_2;
				}else{
					currentConversa = conversa_3;
				}
				
			}else{
				currentConversa = conversa_3;
			}
			
		}
	}
	
	void Update () {
		
		if(talking){
			if(Input.GetKeyDown(KeyCode.PageDown)){
				
				if(currentLine < currentConversa.Length - 1){
					currentLine++;
					GetingTalk();
					_talking = currentConversa[currentLine];
					GameObject.Find("globalTime").GetComponent<globalTIME>().Disenable = false;
				}else{
					currentLine = 1;
					_talking = "";
					talking = false;
					GameObject.Find("globalTime").GetComponent<globalTIME>().Disenable = true;
					if(camDesactive){
						GameObject.Find("MiniMap").camera.enabled = true;
					}
				}
			}
		}
	}
}
