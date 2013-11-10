using UnityEngine;
using System.Collections;

public class CamManager : MonoBehaviour {

    private bool camFirst;
    private TweenAlpha tweenMonitor;
    public GameObject tweenObject;

    private string CamType;

    public Camera firstPerson;
    public Camera thirdPerson;

	// Use this for initialization
	void Start () {
        camFirst = false;
        tweenMonitor = tweenObject.GetComponent<TweenAlpha>();
        tweenMonitor.enabled = true;
        //tweenMonitor.PlayReverse();
    }
	
	// Update is called once per frame
	void Update () {

	
	}

    void fadeIn()
    {
        tweenMonitor.PlayReverse();
        EventDelegate.Set(tweenMonitor.onFinished, changeCamFade);
    }

    void changeCamFade()
    {
        EventDelegate.Remove(tweenMonitor.onFinished, changeCamFade);

        switch (CamType)
        {
            case "FPS":
            camFirst = true;
            firstPerson.gameObject.SetActive(true);
            thirdPerson.gameObject.SetActive(false);
            tweenMonitor.PlayForward();
                break;
            case "TPS":
            camFirst = false;
            firstPerson.gameObject.SetActive(false);
            thirdPerson.gameObject.SetActive(true);
            tweenMonitor.PlayForward();
                break;
        }
    }

    void OnTriggerEnter(Collider hitArea) {
        if (hitArea.name == "IgrejaCollider") {
            CamType = "FPS";
            fadeIn();
        }
    }

    void OnTriggerExit(Collider hitArea) {
        if (hitArea.name == "IgrejaCollider") {
            CamType = "TPS";
            fadeIn();
        }
    }
}
