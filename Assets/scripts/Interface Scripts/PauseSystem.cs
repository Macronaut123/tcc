using UnityEngine;
using System.Collections;

public class PauseSystem : MonoBehaviour {

    public static bool Paused;
    public GameObject PauseScreen;

	// Use this for initialization
	void Start () {

        Paused = false;

	}
	
	// Update is called once per frame
	void Update () {

        if (Paused)
        {
            PauseScreen.SetActive(true);
            Time.timeScale = 0.0F;
        }
        else
        {
            PauseScreen.SetActive(false);
            Time.timeScale = 1.0F;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!Paused)
            {
                Paused = true;
            }
            else
            {
                Paused = false;
            }
        }
	}
}
