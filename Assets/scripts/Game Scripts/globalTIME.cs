using UnityEngine;
using System.Collections;

public class GlobalTime : MonoBehaviour {

    public float globalTimer = 21600f;
	public bool disable = true;

    public void Update()
    {	
		if(disable){
			globalTimer += Time.deltaTime;
		}
	}

    public int getTimeEqualIndex()
    {
        return (int)this.globalTimer / 3600;
    }

    public void setNewTimer(float newTimer)
    {
        globalTimer = newTimer;
    }

    public string FormatSeconds(float elapsed)
    {
		
	    float d = (elapsed * 100.0f);
        float seconds = Mathf.Floor((d % (60 * 100)) / 100);
	    float minutes = Mathf.Floor(d / (60 * 100));
		float hours = Mathf.Floor(minutes / 60 );
		return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
	}

    public void OnGUI()
    {
		GUI.Label(new Rect(10,10,150,50), FormatSeconds(globalTimer));	
	}
}
