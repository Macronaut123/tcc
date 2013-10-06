using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalActions : GenericFunction
{

    public void action(int hour, int minut, float second, bool resetAll)
    {
        setNewTimer(hour, minut, second);
        GameObject[] a = GameObject.FindGameObjectsWithTag("canBack");
		
        foreach (GameObject temp in a)
        {
            if (temp.GetComponent<AiBasic>())
            {
                temp.GetComponent<AiBasic>().getNewCurrentContainer();
            }
			
   			temp.GetComponent<NpcSystemBackTime>().goToPosition(temp.GetComponent<AiBasic>().getSubContainerWayPoint());
        }
    }

    public void Update()
    {
        if (!GameObject.Find("PlayerRoom").GetComponent<GlobalActivePlayerRoom>().isReadyToBack)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
				var h = hour();
				var m = minut();
				
				var mTemp = 1;
				var hTemp = 1;
				
				if(m < 30){
					mTemp = 30;
					hTemp = h;
				}else{
					mTemp = 0;
					hTemp = h + 1;		
				}
				if(hTemp < 22){
					action(hTemp, mTemp , 0f, true);
				}
	            
            }
			if (Input.GetKeyDown(KeyCode.Alpha1))
            {
				var h = hour();
				var m = minut();
				
				var mTemp = 1;
				var hTemp = 1;
				
				if(m >= 30){
					mTemp = 0;
					hTemp = h;
				}else{
					mTemp = 30;
					hTemp = h - 1;		
				}
				
				if(hTemp > 5){
					action(hTemp, mTemp , 0f, true);	
				}
            }
		}
    }
}