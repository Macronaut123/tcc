using UnityEngine;
using System.Collections;

public class CamManager : MonoBehaviour {

    private bool camFirst;

    public Camera firstPerson;
    public Camera thirdPerson;

	// Use this for initialization
	void Start () {
        camFirst = false;
    }
	
	// Update is called once per frame
	void Update () {

	
	}

    void OnTriggerEnter(Collider hitArea) {
        if (hitArea.name == "IgrejaCollider") {
            camFirst = true;
            
            firstPerson.gameObject.SetActive(true);
            thirdPerson.gameObject.SetActive(false);
        }
    }

    void OnTriggerExit(Collider hitArea) {
        if (hitArea.name == "IgrejaCollider") {
            camFirst = false;
            firstPerson.gameObject.SetActive(false);
            thirdPerson.gameObject.SetActive(true);
        }
    }
}
