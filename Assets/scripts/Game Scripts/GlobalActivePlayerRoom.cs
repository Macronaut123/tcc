using UnityEngine;
using System.Collections;

public class GlobalActivePlayerRoom : MonoBehaviour
{
    public bool isReadyToBack = false;

    public void OnTriggerEnter(Collider hit)
    {
        if (hit.name == "Player")
        {
            isReadyToBack = true;
        }
    }
}