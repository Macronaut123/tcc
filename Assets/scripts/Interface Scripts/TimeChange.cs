using UnityEngine;
using System.Collections;

public class TimeChange : MonoBehaviour {

    private exSpriteFont fontControl;
    private GameObject globalTime;
    private GameObject playerControl;

	// Use this for initialization
	void Start () {

        fontControl = gameObject.GetComponent<exSpriteFont>();
        globalTime = GameObject.FindGameObjectWithTag("GlobalTime");
        playerControl = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver() {

        fontControl.topColor = Color.green;
        fontControl.botColor = Color.green;

    }

    void OnMouseExit() {

        fontControl.topColor = Color.black;
        fontControl.botColor = Color.black;   

    }

    void OnMouseDown() {
        int hour = int.Parse(this.name.Substring(0,2));
        int minut = int.Parse(this.name.Substring(2,2));
        playerControl.GetComponent<GlobalActions>().action(hour, minut, 0, true);
        globalTime.GetComponent<GlobalTime>().setNewTimer(hour, minut, 0);
    }
}