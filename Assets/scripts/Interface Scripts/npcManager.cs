using UnityEngine;
using System.Collections;

public class npcManager : MonoBehaviour {

    public static bool Persival;
    public static bool Drake;
    public static bool Ulric;
    public static bool Klaus;
    public static bool Tobbie;
    public static bool Aina;
    public static bool Argus;
    public static bool Benn;
    public static bool Gunvar;
    public static bool Finn;
    public static bool Encapuzado;
    public static bool Rikki;
    public static bool Alvis;

    public GameObject PersivalObject;
    public GameObject DrakeObject;
    public GameObject UlricObject;
    public GameObject KlausObject;
    public GameObject TobbieObject;
    public GameObject AinaObject;
    public GameObject ArgusObject;
    public GameObject BennObject;
    public GameObject GunvarObject;
    public GameObject FinnObject;
    public GameObject EncapuzadoObject;
    public GameObject RikkiObject;
    public GameObject AlvisObject;


	// Use this for initialization
	void Start () {

        Persival = false;
        Drake = false;
        Ulric = false;
        Klaus = false;
        Tobbie = false;
        Argus = false;
        Aina = false;
        Benn = false;
        Gunvar = false;
        Finn = false;
        Encapuzado = false;
        Rikki = false;
        Alvis = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Persival) { PersivalObject.SetActive(true); } else { PersivalObject.SetActive(false); }
        if (Drake) { DrakeObject.SetActive(true); } else { DrakeObject.SetActive(false); }
        if (Ulric) { UlricObject.SetActive(true); } else { UlricObject.SetActive(false); }
        if (Klaus) { KlausObject.SetActive(true); } else { KlausObject.SetActive(false); }
        if (Tobbie) { TobbieObject.SetActive(true); } else { TobbieObject.SetActive(false); }
        if (Aina) { AinaObject.SetActive(true); } else { AinaObject.SetActive(false); }
        if (Argus) { ArgusObject.SetActive(true); } else { ArgusObject.SetActive(false); }
        if (Benn) { BennObject.SetActive(true); } else { BennObject.SetActive(false); }
        if (Finn) { FinnObject.SetActive(true); } else { FinnObject.SetActive(false); }
        if (Encapuzado) { EncapuzadoObject.SetActive(true); } else { EncapuzadoObject.SetActive(false); }
        if (Gunvar) { GunvarObject.SetActive(true); } else { GunvarObject.SetActive(false); }
        if (Rikki) { RikkiObject.SetActive(true); } else { RikkiObject.SetActive(false); }
        if (Alvis) { AlvisObject.SetActive(true); } else { AlvisObject.SetActive(false); }
	}
}
