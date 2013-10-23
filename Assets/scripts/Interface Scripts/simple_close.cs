using UnityEngine;
using System.Collections;

public class simple_close : MonoBehaviour {

    public GameObject menu_to_close;
    private exSprite close_btn;

    public GameObject open_button;

    public float goX;
    public float goY;

    private bool ableToClick;

	public float timeDelay;

	// Use this for initialization
	void Start () {
        ableToClick = true;
        close_btn = gameObject.GetComponent<exSprite>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
            iTween.MoveTo(menu_to_close, iTween.Hash("x", goX, "y", goY, "z", transform.position.z, "time", timeDelay));
    }

    void OnMouseOver() {
        close_btn.color = Color.red;
    }

    void OnMouseExit() {
        close_btn.color = Color.white;
    }
}
