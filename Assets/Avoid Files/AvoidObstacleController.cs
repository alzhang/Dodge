using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidObstacleController : MonoBehaviour {
    private float buffer = 500;
	
	// Update is called once per frame
	void Update () {
	    if(transform.position.x > Screen.width + buffer || transform.position.x < -Screen.width - buffer || transform.position.y > Screen.height + buffer || transform.position.y < -Screen.height - buffer)
        {
            Destroy(gameObject);
        }	
	}
}
