using UnityEngine;
using System.Collections;

public class ChangeTime : MonoBehaviour {

    private UILabel timeText;
    private GameObject globalActions;

	// Use this for initialization
	void Start () {

        timeText = gameObject.GetComponent<UILabel>();
        globalActions = GameObject.Find("Player");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick() { 
        //print(timeText.text.Substring(0,1));
        //print(timeText.text.Substring(2, 2));
        globalActions.GetComponent<GlobalActions>().action(int.Parse(gameObject.name.Substring(0, 2)), int.Parse(gameObject.name.Substring(2, 2)), 0, false);
    }
}
