using UnityEngine;
using System.Collections;

public class PlayerCollides : MonoBehaviour {

    public static string CollisionName;
    public static bool Quarto;
	public GameObject Relogio;
    
    // Use this for initialization
	void Start () {
		Relogio.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider HitArea) {

        switch (HitArea.name) {
            case "CemiterioCollider":
                CollisionName = "Cemiterio";
                break;
            case "CidadeCollider":
                CollisionName = "Cidade";
                break;
            case "IgrejaCollider":
                CollisionName = "Igreja";
                break;
            case "QuartoCollider":
			Relogio.SetActive(true);
                Quarto = true;
                break;
        }

    }

    void OnTriggerExit(Collider hitArea) {
        switch (hitArea.name)
        {
            case "QuartoCollider":
			Relogio.SetActive(false);
                Quarto = false;
                break;
            
        }
    }
}
