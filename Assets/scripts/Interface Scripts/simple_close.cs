using UnityEngine;
using System.Collections;

public class simple_close : MonoBehaviour {

    public GameObject menu_to_close;
    private exSprite close_btn;
	public Vector3[] reachingPlace;
	public float timeDelay;

	// Use this for initialization
	void Start () {
        close_btn = gameObject.GetComponent<exSprite>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        iTween.MoveTo(menu_to_close,reachingPlace[0],timeDelay);
    }

    void OnMouseOver() {
        close_btn.color = Color.red;
    }

    void OnMouseExit() {
        close_btn.color = Color.white;
    }
}
