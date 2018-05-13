using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEnvironmentGenerator : MonoBehaviour {

    public GameObject playerObject;
    public GameObject planeObject;
    public GameObject obstacle;

    public float minSize = .7f;
    public float lookaheadDistance = 50f;

    private float currentDistance = 20f;
    private Vector3 previousPosition;
    private Vector3 previousSize;

	// Use this for initialization
	void Start () {
        currentDistance = planeObject.transform.localScale.z;

        previousPosition = planeObject.transform.position;
        previousSize = planeObject.GetComponent<Collider>().bounds.size;
       
    }
	
	// Update is called once per frame
	void Update () {
		if(playerObject.transform.position.z + lookaheadDistance > currentDistance)
        {
            GenerateNewPlane();
        }
	}

    void GenerateNewObstacle(Vector3 position, Vector3 size, GameObject parent)
    {
        float randX = Random.value*size.x + (position.x - size.x/2);
        float randZ = Random.value * size.z + (position.z - size.z / 2);
        GameObject newObstacle = Instantiate(obstacle, parent.transform);
        newObstacle.transform.position = new Vector3(randX, newObstacle.GetComponent<Collider>().bounds.size.y/2, randZ);
    }

    void GenerateNewPlane()
    {
        GameObject newPlane = Instantiate(planeObject, transform);

        float newRatio= Random.value * (1 - minSize) + minSize;
        newPlane.transform.localScale = new Vector3(planeObject.transform.localScale.x * newRatio, planeObject.transform.localScale.y, planeObject.transform.localScale.z);

        Vector3 newPosition = new Vector3(Random.value * previousSize.x + (previousPosition.x - previousSize.x / 2), 0, previousPosition.z + previousSize.z);
        newPlane.transform.position = newPosition;

        previousPosition = newPosition;
        previousSize = newPlane.GetComponent<Collider>().bounds.size;
        currentDistance += newPlane.GetComponent<Collider>().bounds.size.z;

        for (int i = 0; i < Mathf.Log(MainGameStateController.score); i++)
        {
            GenerateNewObstacle(previousPosition, previousSize, newPlane);
        }

        /*
         * float rand = Random.value * (1-minSize) + minSize;
        float width = newPlane.GetComponent<Collider>().bounds.size.x * newPlane.transform.localScale.x;
        float length = newPlane.GetComponent<Collider>().bounds.size.z * newPlane.transform.localScale.z;

        Vector3 current = newPlane.transform.localScale;
        
        newPlane.transform.localScale = new Vector3(current.x * rand, current.y, current.z);
        float newX = Random.value * previousWidth - previousX/2;

        newPlane.transform.position = new Vector3(newX, 0, currentDistance);
        currentDistance += newPlane.GetComponent<Collider>().bounds.size.z;

        for(int i = 0; i < Mathf.Log(MainGameStateController.score); i++)
        {
            GenerateNewObstacle(previousX, 0, currentDistance, width, length, newPlane);
        }


        previousWidth = width * rand;
        previousX = newX;*/
    }
}
