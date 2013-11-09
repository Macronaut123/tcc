using UnityEngine;
using System.Collections;

public class TextoControle : MonoBehaviour {
	
	public HUDText Texto;
	private bool QuartoOne;
	
	// Use this for initialization
	void Start () {
		QuartoOne = false;
		Texto.Add("Caramba, olha a hora! Acho que o Tobbie foi para a Igreja!\nMelhor eu ver se a missa começou...",Color.white,4);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider hit){
		if(hit.name == "QuartoCollider"){
			if(!QuartoOne){
				QuartoOne = true;
				Texto.Add("Hmm, eu me lembro deste quarto, melhor eu acessar o menu de pausa apertando I,\ntalvez eu encontre algo importante.",Color.white,4);
			}
		}
	}
}
