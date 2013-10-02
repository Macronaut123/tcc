using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class basicAI : MonoBehaviour 
{
	
   public enum NPCStates{
		stopwalk,
        walkToNext
    }

   	public NPCStates state = NPCStates.walkToNext;
	
	private GameObject waypointContainer;
    public List<Transform> waypoints;
    
	public float balance_tick = 0;
	public float global_time;
	
	public int currentWayPoint;
	public int tick_time;
	public int last_tick;
	public int dividor_time = 60;
	
	public Vector3 direction;
	
	public bool key_001;
	
    public void Start(){
		prepareToStart();
        currentWayPoint = 0;
		FindWayPoints();
    }
	
	public void FindWayPoints(){
		
		if(gameObject.name == "NPC_guardaForte"){
			
			if(!key_001){
				waypointContainer = GameObject.Find(gameObject.name+"_WP");
			}else{
				waypointContainer = GameObject.Find(gameObject.name+"_WP_02");
			}
			
		}else{
			waypointContainer = GameObject.Find(gameObject.name+"_WP");
		}
        
        Transform[] potentialWayPoints = waypointContainer.GetComponentsInChildren<Transform>();
        waypoints = new List<Transform>();

        for (int i = 1; i < potentialWayPoints.Length; i++)
        {
            waypoints.Add(potentialWayPoints[i]);
        }
    }
	
	public void prepareToStart(){
		key_001 = GameObject.Find("objetivo_001").GetComponent<objetivos_001>().key_001;
		global_time = GameObject.Find("globalTime").GetComponent<GlobalTime>().globalTimer;
		tick_time = (int)global_time / dividor_time; //start = 5
		last_tick = tick_time;
	}	
	
    public void Update(){
		
		key_001 = GameObject.Find("objetivo_001").GetComponent<objetivos_001>().key_001;
		global_time = GameObject.Find("globalTime").GetComponent<GlobalTime>().globalTimer;
		tick_time = (int)global_time / dividor_time; //start = 5
		
		if(last_tick > tick_time){
			last_tick = tick_time;
		}
		
		if(tick_time > last_tick - balance_tick){
			
			state = NPCStates.walkToNext;
		
		}else{
			state = NPCStates.stopwalk;
		}
		
		if(state == NPCStates.walkToNext){
			weepWalk();
			walkToNext(currentWayPoint);
			
		}else if(state == NPCStates.stopwalk){
			
			stopwalk();
		}
		
    }
	
	public void weepWalk(){
		
		rigidbody.isKinematic = false;
	}
	
	public void stopwalk(){
		
		rigidbody.isKinematic = true;
	}
	
	public void walkToNext(int currentWay){
				
		direction = waypoints[currentWay].position - transform.position;
		
		Vector3 next = waypoints[currentWay].position;
		
        if (direction.magnitude <= 1){
			
			last_tick = tick_time;
			
			currentWayPoint++;
			
			if (currentWayPoint >= waypoints.ToArray().Length){
				
				currentWayPoint = 0;
			}
			
        }else{
			GetComponent<NavMeshAgent>().destination = next;
        }
	}
}
