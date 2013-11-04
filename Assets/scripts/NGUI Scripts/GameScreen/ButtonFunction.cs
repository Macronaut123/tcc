using UnityEngine;
using System.Collections;

public class ButtonFunction : MonoBehaviour {

    public string FunctionType;
    public GameObject Target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick() {
        switch (FunctionType)
        {
            case "Enable":
                Target.SetActive(true);
                Time.timeScale = 0;
                break;
            case "Disable":
                Target.SetActive(false);
                Time.timeScale = 1;
                break;
        }
    }
}
