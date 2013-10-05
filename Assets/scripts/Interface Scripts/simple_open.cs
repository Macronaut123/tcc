using UnityEngine;
using System.Collections;

public class simple_open : MonoBehaviour {

    public GameObject menu_to_open;
    public GameObject second_menu;
    private exSpriteBorder open_btn;
	public Vector3[] placetoGo;
	public float timeDelay;

	// Use this for initialization
	void Start () {
        open_btn = gameObject.GetComponent<exSpriteBorder>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
		iTween.MoveTo(menu_to_open,placetoGo[0],timeDelay);
		if(second_menu != null){iTween.MoveTo(second_menu,placetoGo[1],timeDelay);}
    }

    void OnMouseOver() {
        open_btn.color = Color.green;
    }

    void OnMouseExit() {
        open_btn.color = Color.white;
    }
}
