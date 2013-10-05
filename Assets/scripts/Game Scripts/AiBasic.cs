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


    List<GameObject> subContainers;

    public void Start()
    {
        calculateGlobalTime(true);
        defineCurrentContainer(findSubContainers(), calculeIndex());
    }

    public List<GameObject> findSubContainers()
    {
        GameObject container = GameObject.Find(gameObject.name + "_WP");
        Transform[] mainContainer = container.GetComponentsInChildren<Transform>();
        subContainers = new List<GameObject>();
        foreach (Transform temp in mainContainer)
        {
            if (!temp.gameObject.name.Contains("NPC"))
            {
                subContainers.Add(temp.gameObject);
            }
        }
        return subContainers;
    }

    public int calculeIndex()
    {
        var h = hour();
        var m = minut();
        var add = 0;

        if (m >= 30)
        {
            add = 1;
        }

        var a = (h - 6);
        var b = a * 2;
        var index = b + add;

        //print(h+ " "+ m +" "+ a + " " + b + " " + c + " " + add);

        return index;
    }

    public void defineCurrentContainer(List<GameObject> subContainers, int index)
    {
        Transform[] currentContainer = subContainers[index].GetComponentsInChildren<Transform>();
        wayPoints = new List<Transform>();
        for (int i = 1; i < currentContainer.Length; i++)
        {
            wayPoints.Add(currentContainer[i]);
        }
    }

    public void defineCurrentContainer(int index)
    {
        Transform[] currentContainer = subContainers[index].GetComponentsInChildren<Transform>();
        wayPoints = new List<Transform>();
        for (int i = 1; i < currentContainer.Length; i++)
        {
            wayPoints.Add(currentContainer[i]);
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
            defineCurrentContainer(calculeIndex());
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