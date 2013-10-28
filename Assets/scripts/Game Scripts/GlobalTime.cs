using UnityEngine;
using System.Collections;

public class GlobalTime : MonoBehaviour
{
    public bool disable = true;
    public float second = 0f;
    public int minut = 0;
    public int hour = 6;
	public int multiplicador = 20;
	
	public Camera mainCamera;
	
	private void Awake(){
	
		disable = true;
	}
	
    private void FixedUpdate()
    {
		if(Application.loadedLevelName != "Zeitland" ){
			return;	
		}
		
		if(this.hour == 21){
			checkWhatFinal();
		}
		
        if (disable)
        {
            if (second >= 60)
            {
                minut = minut + 1;
                second = 0f;
            }
            else
            {
                second += Time.deltaTime * multiplicador;
            }

            if (minut == 60)
            {
                minut = 0;
                hour = hour + 1;
            }
        }
    }
	
	public void checkWhatFinal(){
		var dp = GameObject.Find("Player").GetComponent<NpcObjectives>().dependencyActions;
		
		
		if(dp["FINAL_BAD"] == true){
			
		}
		else if(dp["FINAL_GOOD"] == true){
			
		}
		else if(dp["FINAL_PERFECT"] == true){
			
		}else /*DEFAULT	*/ {
			mainCamera.farClipPlane -= 100 * Time.deltaTime;
			if(mainCamera.farClipPlane < 0){
				Application.LoadLevel("FINAL_DEFAULT");
			}
		}
	}

    public void setNewTimer(int hour, int minut, float second)
    {
        if (PlayerCollides.Quarto)
        {
            this.hour = hour;
            this.minut = minut;
            this.second = second;
        }
    }

    private string FormatSeconds()
    {
        return string.Format("{0:00}:{1:00}:{2:00}", hour, minut, second);
    }

    private void OnGUI()
    {
		if(Application.loadedLevelName == "Zeitland" ){
        	GUI.Label(new Rect(10, 10, 150, 50), FormatSeconds());
		}
    }

    public void setNewDisable(bool disable)
    {
        this.disable = disable;
    }
}
