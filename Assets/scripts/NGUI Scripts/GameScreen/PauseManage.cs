using UnityEngine;
using System.Collections;

public class PauseManage : MonoBehaviour {

    public GameObject Target;
    public GameObject tweenObject;
    private TweenAlpha tweenMonitor;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        Target.SetActive(false);
        tweenMonitor = tweenObject.GetComponent<TweenAlpha>();
	}

    void fadeIn() {
        tweenMonitor.PlayReverse();
        EventDelegate.Set(tweenMonitor.onFinished, fadeOut);
    }

    void fadeOut() {
        EventDelegate.Remove(tweenMonitor.onFinished, fadeOut);
        tweenMonitor.PlayForward();
        changePause();
    }

    void changePause() {
        if (!Target.activeSelf) { Target.SetActive(true); Time.timeScale = 0; } else { Target.SetActive(false); Time.timeScale = 1; }
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.I)) {
            fadeIn();
        }

	}
}
