using UnityEngine;
using System.Collections;

public class PauseManage : MonoBehaviour {

    public GameObject Target;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        Target.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.I)) {
            if (!Target.activeSelf) { Target.SetActive(true); Time.timeScale = 0; } else { Target.SetActive(false); Time.timeScale = 1; }
        }

	}
}
