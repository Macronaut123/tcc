using UnityEngine;
using System.Collections;

public class simple_feedback : MonoBehaviour {

    private exSpriteBorder open_btn;

	// Use this for initialization
	void Start () {
        open_btn = gameObject.GetComponent<exSpriteBorder>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
    }

    void OnMouseOver() {
        open_btn.color = Color.green;
    }

    void OnMouseExit() {
        open_btn.color = Color.white;
    }
}
