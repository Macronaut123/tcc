using UnityEngine;
using System.Collections;

public class simpleChange : MonoBehaviour {

    private exSpriteBorder spriteBorder;

    public GameObject targetChange;
    private ChangeNPCs targetChangeScript;

    public string changeType;

	// Use this for initialization
	void Start () {

        spriteBorder = gameObject.GetComponent<exSpriteBorder>();
        targetChangeScript = targetChange.GetComponent<ChangeNPCs>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        switch (changeType) { 
            case "next":
                targetChangeScript.nextScreen();
            break;
            case "prev":
                targetChangeScript.previousScreen();
            break;
        }
    }

    void OnMouseOver() {

        spriteBorder.color = Color.green;

    }

    void OnMouseExit() {
        spriteBorder.color = Color.white;
    }



}
