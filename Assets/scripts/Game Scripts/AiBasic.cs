using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class AiBasic : GenericFunction
{

    public enum NPCStates
    {
        stopWalk,
        walkToNext
    }

    public NPCStates state = NPCStates.walkToNext;

    private GameObject waypointContainer;
    public string wayPointContainerName;
    public List<Transform> wayPoints;
    public float balanceTick = 0;
    public int currentWayPoint;
    public int tickTime;
    public int lastTick;
    public int limitForWalk = 60;
    public Vector3 direction;


    public Dictionary<String,GameObject> subContainers = new Dictionary<String, GameObject>();

    public void Start()
    {
        calculateGlobalTime(true);
        defineCurrentContainer(findSubContainers(), calculeIndex());
    }
	
	public void getNewCurrentContainer()
	{
		defineCurrentContainer(calculeIndex());
	}
	
    public Dictionary<String,GameObject> findSubContainers()
    {
        GameObject container = GameObject.Find(gameObject.name + "_WP");
        Transform[] mainContainer = container.GetComponentsInChildren<Transform>();
		subContainers = new Dictionary<string, GameObject>();
        foreach (Transform temp in mainContainer)
        {
            if (!temp.gameObject.name.Contains("NPC") || !temp.gameObject.name.Contains("Evento") )
            {
				if(!this.subContainers.ContainsKey(temp.gameObject.name)){
                	this.subContainers.Add(temp.gameObject.name, temp.gameObject);
				}
            }
        }
        return this.subContainers;
    }
	
	public string calculeIndex()
    {
			var h = hour();
			var m = minut();
			
			var key = "";
		
			if(h == 6 && m < 30){
				key = "0600";
			}
			else if(h == 6 && m >= 30){
				key = "0630";
			}
			else if(h == 7 && m < 30){
				key = "0700";
			}
			else if(h == 7 && m >= 30){
				key = "0730";
			}
			else if(h == 8 && m < 30){
				key = "0800";
			}
			else if(h == 8 && m >= 30){
				key = "0830";
			}
			else if(h == 9 && m < 30){
				key = "0900";
			}
			else if(h == 9 && m >= 30){
				key = "0930";
			}
			else if(h == 10 && m < 30){
				key = "1000";
			}
			else if(h == 10 && m >= 30){
				key = "1030";
			}
			else if(h == 11 && m < 30){
				key = "1100";
			}
			else if(h == 11 && m >= 30){
				key = "1130";
			}
			else if(h == 12 && m < 30){
				key = "1200";
			}
			else if(h == 12 && m >= 30){
				key = "1230";
			}
			else if(h == 13 && m < 30){
				key = "1300";
			}
			else if(h == 13 && m >= 30){
				key = "1330";
			}
			else if(h == 14 && m < 30){
				key = "1400";
			}
			else if(h == 14 && m >= 30){
				key = "1430";
			}
			else if(h == 15 && m < 30){
				key = "1500";
			}
			else if(h == 15 && m >= 30){
				key = "1530";
			}
			else if(h == 16 && m < 30){
				key = "1600";
			}
			else if(h == 16 && m >= 30){
				key = "1630";
			}
			else if(h == 17 && m < 30){
				key = "1700";
			}
			else if(h == 17 && m >= 30){
				key = "1730";
			}
			else if(h == 18 && m < 30){
				key = "1800";
			}
			else if(h == 18 && m >= 30){
				key = "1830";
			}
			else if(h == 19 && m < 30){
				key = "1900";
			}
			else if(h == 19 && m >= 30){
				key = "1930";
			}
			else if(h == 20 && m < 30){
				key = "2000";
			}
			else if(h == 20 && m >= 30){
				key = "2030";
			}
			else if(h == 21 && m < 30){
				key = "2100";
			}
			else if(h == 21 && m >= 30){
				key = "2130";
			}
			else if(h == 22 && m < 30){
				key = "2200";
			}
		
        return "WP_"+key;
    }
	
	public Transform getSubContainerWayPoint()
	{
		Transform[] currentContainer = findSubContainers()[calculeIndex()].GetComponentsInChildren<Transform>();
		Transform tempWayPoints = currentContainer[1];
		return tempWayPoints;
	}
	
	public void defineCurrentContainer(GameObject subContainers)
    {
        Transform[] currentContainer = subContainers.GetComponentsInChildren<Transform>();
        wayPoints = new List<Transform>();
        for (int i = 1; i < currentContainer.Length; i++)
        {
            wayPoints.Add(currentContainer[i]);   
		}
	}
	
    public void defineCurrentContainer(Dictionary<String,GameObject> subContainers, string index)
    {
		if (subContainers.ContainsKey(index))
		{
	        Transform[] currentContainer = subContainers[index].GetComponentsInChildren<Transform>();
	        wayPoints = new List<Transform>();
	        for (int i = 1; i < currentContainer.Length; i++)
	        {
	            wayPoints.Add(currentContainer[i]);   
			}
		}else{
            Debug.Log("subWP " + index + "nao encontrado");
		}
    }
	
    public void defineCurrentContainer(string index)
    {
        if (subContainers.ContainsKey(index))
		{
	        Transform[] currentContainer = subContainers[index].GetComponentsInChildren<Transform>();
	        wayPoints = new List<Transform>();
	        for (int i = 1; i < currentContainer.Length; i++)
	        {
	            wayPoints.Add(currentContainer[i]);   
			}
		}else{
			Debug.Log("subWP "+ index +"nao encontrado");
		}
    }

    public void calculateGlobalTime(bool calculeLastTick)
    {
        tickTime = minut();

        if (calculeLastTick)
        {
            lastTick = tickTime;
        }
    }

    public void Update()
    {
        calculateGlobalTime(false);
        Action();
    }

    private void Action()
    {
        if (tickTime == 0 || tickTime == 30)
        {
            defineCurrentContainer(findSubContainers(), calculeIndex());
            state = NPCStates.walkToNext;
            lastTick = tickTime;
        }

        if (true)
        {
            state = NPCStates.walkToNext;
        }
        if (state == NPCStates.walkToNext)
        {
            weepOrStopWalk(true);
            walkToNext(currentWayPoint);
        }
        else if (state == NPCStates.stopWalk)
        {
            weepOrStopWalk(false);
        }
    }

    public void weepOrStopWalk(bool what)
    {

        rigidbody.isKinematic = what;
    }

    public void walkToNext(int currentWay)
    {
        direction = wayPoints[currentWay].position - transform.position;
        Vector3 next = wayPoints[currentWay].position;

        if (direction.magnitude <= 1)
        {
            currentWayPoint++;

            if (currentWayPoint >= wayPoints.ToArray().Length)
            {
                currentWayPoint = 0;
            }
        }
        else
        {
            GetComponent<NavMeshAgent>().destination = next;
        }
    }
}