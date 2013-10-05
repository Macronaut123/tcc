using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NpcSystemBackTime : MonoBehaviour {

    public List<Transform> wayPoints;

    public void goToPosition(Transform position)
    {
        //gameObject.transform.position = new Vector3(wayPoints[index].position.x, wayPoints[index].position.y, wayPoints[index].position.z);
		gameObject.transform.position = new Vector3(position.position.x, position.position.y , position.position.z);
    }

}
