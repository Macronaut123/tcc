using UnityEngine;
using System.Collections;

public class ChangeNPCs : MonoBehaviour {

    public GameObject[] screens;
    int currentScreen = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < screens.Length; i++) {
            if (screens[i] != screens[currentScreen])
            {
                screens[i].SetActive(false);
            }
            else
            {
                screens[i].SetActive(true);
            }
        }

    }

    public void nextScreen(){
        if (currentScreen < screens.Length-1) { currentScreen++; }
    }

    public void previousScreen() {
        if (currentScreen > 0) { currentScreen--; }
    }

}
