using UnityEngine;
using System.Collections;

public class PlayerCollides : MonoBehaviour {

    public static string CollisionName;
    
    // Use this for initialization
	void Start () {
	
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
        }

    }
}
