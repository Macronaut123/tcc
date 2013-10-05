using UnityEngine;
using System.Collections;

public class interact : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            gameObject.animation.CrossFade("Correndo");
        }
    }
}
