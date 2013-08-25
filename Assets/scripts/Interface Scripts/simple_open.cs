using UnityEngine;
using System.Collections;

public class simple_open : MonoBehaviour {

    public GameObject menu_to_open;
    public GameObject second_menu;
    private exSpriteBorder open_btn;

	// Use this for initialization
	void Start () {
        open_btn = gameObject.GetComponent<exSpriteBorder>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {

        if (second_menu != null)
        {
                second_menu.SetActive(true);
        }
           

        if(!menu_to_open.activeSelf)
                menu_to_open.SetActive(true);
            else
                menu_to_open.SetActive(false);
    }

    void OnMouseOver() {
        open_btn.color = Color.green;
    }

    void OnMouseExit() {
        open_btn.color = Color.white;
    }
}
