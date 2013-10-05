using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalActions : GenericFunction
{

    public bool haveChurchKey = false;

    //Tutorial 6 ~ 7
    public bool ainaCanMove = false;
    public bool knowToBack = false;
    public bool objStart = true;
    public bool obj001_Aina = false;
    public bool obj002_Aina = false;
    public bool obj001_Alviss = false;
    public bool obj002_Alviss = false;
	
    public string[] NPC_Aina_01;
    public string[] NPC_Aina_02;
    public string[] NPC_Alviss_01;
    public string[] NPC_Alviss_02;

    private bool haveBackedOneTime = false;

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
               /*
            else if (temp.GetComponent<AiTwoActions>())
            {
                if (resetAll)
                {
                    temp.GetComponent<AiTwoActions>().currentWayPoint = resetNumber;
                    GameObject.Find("NPC_Aina").GetComponent<AiTwoActions>().findFirstWayPoints("_WP");
                }
            }
                  */ 
			
   			temp.GetComponent<NpcSystemBackTime>().goToPosition(temp.GetComponent<AiBasic>().getSubContainerWayPoint());
        }
    }

    public void Update()
    {
        if (GameObject.Find("PlayerRoom").GetComponent<GlobalActivePlayerRoom>().isReadyToBack)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
	            action(6, 0 , 0f, true);
	            haveBackedOneTime = true;
            }
		}
    }

    public void OnTriggerEnter(Collider hit)
    {
        if (hit.name == "ChurchKey")
        {
            if (!haveChurchKey)
            {
                haveChurchKey = true;
                hit.gameObject.collider.enabled = false;
                hit.gameObject.renderer.enabled = false;
            }
        }

        if (hit.name == "NPC_Aina")
        {
            if (objStart && !obj001_Alviss && !obj002_Alviss && !obj001_Aina && !obj002_Aina && !knowToBack) //ela 
            {
                obj001_Aina = true;
                //hit.GetComponent<NpcSystemTalk>().getTalkForThisAction(NPC_Aina_01);
                return;
            }
            if (objStart && obj001_Alviss && !obj002_Alviss && !obj001_Aina && !obj002_Aina && knowToBack && haveBackedOneTime) // ele , ~ , ela
            {
                obj001_Aina = true;
                obj002_Aina = true;
                ainaCanMove = true;
               // hit.GetComponent<NpcSystemTalk>().getTalkForThisAction(NPC_Aina_02);
                return;
            }
            if (objStart && obj001_Alviss && !obj002_Alviss && obj001_Aina && !obj002_Aina && knowToBack && haveBackedOneTime) // ela , ele , ~ , ela
            {
                obj002_Aina = true;
                ainaCanMove = true;
               // hit.GetComponent<NpcSystemTalk>().getTalkForThisAction(NPC_Aina_02);
                return;
            }
        }
        if (hit.name == "NPC_Alviss")
        {
            if (objStart && !obj001_Alviss && !obj002_Alviss && !obj001_Aina && !obj002_Aina && !knowToBack) // ele , ~
            {
                obj001_Alviss = true;
                knowToBack = true;
               // hit.GetComponent<NpcSystemTalk>().getTalkForThisAction(NPC_Alviss_02);
                //GameObject.Find("NPC_Aina").GetComponent<AiTwoActions>().findFirstWayPoints("_WP_02");
                return;
            }
            if (objStart && !obj001_Alviss && !obj002_Alviss && obj001_Aina && !obj002_Aina && !knowToBack) // ela , ele , ~
            {
                obj001_Alviss = true;
                knowToBack = true;
               // hit.GetComponent<NpcSystemTalk>().getTalkForThisAction(NPC_Alviss_02);
                return;
            }

            if (objStart && obj001_Alviss && !obj002_Alviss && obj001_Aina && obj002_Aina && knowToBack) // ela , ele , ~ , ela
            {
                obj002_Alviss = true;
                //haveChurchKey = true;
                GameObject.Find("ChurchKey").gameObject.renderer.enabled = true;
                GameObject.Find("ChurchKey").gameObject.collider.enabled = true;
                //hit.GetComponent<NpcSystemTalk>().getTalkForThisAction(NPC_Alviss_01);
                return;
            }
        }
    }
    public void OnTriggerExit(Collider hit)
    {
        if (hit.name == "NPC_Aina")
        {
            if (ainaCanMove)
            {
                //GameObject.Find("NPC_Aina").GetComponent<AiTwoActions>().findFirstWayPoints("_WP_02");
                return;
            }
        }
    }
    public void resetAllActions()
    {
        obj001_Aina = false;
        obj002_Aina = false;
        obj001_Alviss = false;
        obj002_Alviss = false;
    }
}