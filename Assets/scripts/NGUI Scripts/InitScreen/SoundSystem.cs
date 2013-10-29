using UnityEngine;
using System.Collections;

public class SoundSystem : MonoBehaviour {

    private UIToggle toggleControl;

	// Use this for initialization
	void Start () {
        toggleControl = gameObject.GetComponent<UIToggle>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick() {
        if (toggleControl.value == false) { AudioListener.pause = true; } else { AudioListener.pause = false; }
    }
}
