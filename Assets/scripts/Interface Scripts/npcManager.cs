using UnityEngine;
using System.Collections;

public class npcManager : MonoBehaviour {

    public static bool Persival;
    public static bool Drake;
    public static bool Ulric;
    public static bool Klaus;
    public static bool Tobbie;

    public GameObject PersivalObject;
    public GameObject DrakeObject;
    public GameObject UlricObject;
    public GameObject KlausObject;
    public GameObject TobbieObject;


	// Use this for initialization
	void Start () {

        Persival = false;
        Drake = false;
        Ulric = false;
        Klaus = false;
        Tobbie = false;

	}
	
	// Update is called once per frame
	void Update () {

        if (Persival) { PersivalObject.SetActive(true); } else { PersivalObject.SetActive(false); }
        if (Drake) { DrakeObject.SetActive(true); } else { DrakeObject.SetActive(false); }
        if (Ulric) { UlricObject.SetActive(true); } else { UlricObject.SetActive(false); }
        if (Klaus) { KlausObject.SetActive(true); } else { KlausObject.SetActive(false); }
        if (Tobbie) { TobbieObject.SetActive(true); } else { TobbieObject.SetActive(false); }

	}
}
