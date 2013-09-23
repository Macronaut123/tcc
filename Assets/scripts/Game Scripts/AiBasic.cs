using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class AiBasic : MonoBehaviour
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
    public int limitForWalk = 5;
    public Vector3 direction;
    public float globaTime;

    public void Start()
    {

        calculateGlobalTimeAndLastTick();
        findWayPoints();
    }

    public void findWayPoints()
    {
        currentWayPoint = 0;
        waypointContainer = GameObject.Find(gameObject.name + "_WP");
        Transform[] potentialWayPoints = waypointContainer.GetComponentsInChildren<Transform>();
        wayPoints = new List<Transform>();

        for (int i = 1; i < potentialWayPoints.Length; i++)
        {
            wayPoints.Add(potentialWayPoints[i]);
        }

        gameObject.GetComponent<NpcSystemBackTime>().wayPoints = this.wayPoints;
    }

    public void calculateGlobalTimeAndLastTick()
    {

        globaTime = GameObject.Find("globalTime").GetComponent<GlobalTime>().globalTimer;

        tickTime = (int)globaTime / limitForWalk; //start = 5

        lastTick = tickTime;

        if (lastTick > tickTime)
        {
            lastTick = tickTime;
        }
    }

    public void calculateGlobalTime()
    {

        globaTime = GameObject.Find("globalTime").GetComponent<GlobalTime>().globalTimer;

        tickTime = (int)globaTime / limitForWalk; //start = 5

        if (lastTick > tickTime)
        {
            lastTick = tickTime;
        }
    }

    public void Update()
    {
        calculateGlobalTime();

        if (tickTime > lastTick - balanceTick)
        {
            state = NPCStates.walkToNext;

        }
        else
        {
            state = NPCStates.stopWalk;
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

            lastTick = tickTime;

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