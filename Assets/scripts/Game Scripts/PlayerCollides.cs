using UnityEngine;
using System.Collections;

public class PlayerCollides : MonoBehaviour {

    public static string CollisionName;
    public static bool Cemiterio;
    public static bool Cidade;
    public static bool Igreja;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider HitArea) {

        switch (HitArea.name) {
            case "CemiterioCollider":
                Cemiterio = true;
                CollisionName = "Cemiterio";
                break;
            case "CidadeCollider":
                Cidade = true;
                CollisionName = "Cidade";
                break;
            case "IgrejaCollider":
                Igreja = true;
                CollisionName = "Igreja";
                break;
        }

    }

    void OnTriggerExit(Collider hitArea) {
        switch (hitArea.name)
        {
            case "CemiterioCollider":
                Cemiterio = false;
                break;
            case "CidadeCollider":
                Cidade = false;
                break;
            case "IgrejaCollider":
                Igreja = false;
                break;
        }
    }
}
