using UnityEngine;
using System.Collections;

public class simple_open : MonoBehaviour {

    public GameObject menu_to_open;
    private exSpriteBorder open_btn;

    public float goX;
    public float goY;

	public float timeDelay;

	// Use this for initialization
	void Start () {
        open_btn = gameObject.GetComponent<exSpriteBorder>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
            iTween.MoveTo(menu_to_open, iTween.Hash("x", goX, "y", goY, "z ", transform.position.z, "time", timeDelay));
    }

    void OnMouseOver() {
        open_btn.color = Color.green;
    }

    void OnMouseExit() {
        open_btn.color = Color.white;
    }
}
