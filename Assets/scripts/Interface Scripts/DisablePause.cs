using UnityEngine;
using System.Collections;

public class DisablePause : MonoBehaviour {

    private exSpriteBorder controlBorder;

	// Use this for initialization
	void Start () {
        controlBorder = gameObject.GetComponent<exSpriteBorder>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        controlBorder.color = Color.white;
        PauseSystem.Paused = false;
    }

    void OnMouseOver() {
        controlBorder.color = Color.green;
    }

    void OnMouseExit() {
        controlBorder.color = Color.white;
    }
}
