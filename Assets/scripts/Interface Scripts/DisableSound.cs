using UnityEngine;
using System.Collections;

public class DisableSound : MonoBehaviour {

    private exSpriteBorder localSprite;

	// Use this for initialization
	void Start () {

        localSprite = gameObject.GetComponent<exSpriteBorder>();

	}
	
	// Update is called once per frame
    void Update()
    {
        if (AudioListener.pause == true)
        {
            localSprite.color = Color.red;
        }
        else
        {
            localSprite.color = Color.green;
        }
    }

    void OnMouseDown()
    {
        if(AudioListener.pause == true){
            AudioListener.pause = false;
        }
        else{
            AudioListener.pause = true;
        }
    }
}
