using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidEnvironmentGenerator : MonoBehaviour {

    public GameObject cube;
    public float generateFrequency;
    public float poleFrequency;
    public float velocity;

    private float width=Screen.width, height=Screen.height;

    private float minWidth = Screen.width/10, minHeight = Screen.height/10;
    
	
	// Update is called once per frame
	void Update () {
        if(Random.value < generateFrequency)
        {
            GenerateObstacle();
        }
	}

    void GenerateObstacle()
    {
        GameObject newObstacle = Instantiate(cube, transform);
        if(Random.value < poleFrequency)
        {
            newObstacle.transform.localScale = new Vector3(Random.value * minWidth + minWidth, Random.value * minHeight + minHeight, 1);
        } else
        {
            if(Random.value < .5)
            {
                newObstacle.transform.localScale = new Vector3(20, Random.value * 2 *minHeight + 2*minHeight, 1);
            } else
            {
                newObstacle.transform.localScale = new Vector3(Random.value * 2* minWidth + 2*minWidth, 20, 1);
            }
        }

        if(Random.value < .5)
        {
            if(Random.value < .5)
            {
                newObstacle.transform.position = new Vector3(Random.value * width * 2 - width, -height, Random.value*50 - 25);
                newObstacle.GetComponent<Rigidbody>().velocity = new Vector3(0, velocity, 0);
            } else
            {
                newObstacle.transform.position = new Vector3(Random.value * width * 2- width , height, Random.value * 50 - 25);
                newObstacle.GetComponent<Rigidbody>().velocity = new Vector3(0, -velocity, 0);
            }
        } else
        {
            if(Random.value < .5)
            {
                newObstacle.transform.position = new Vector3(width, Random.value * height * 2- height, Random.value * 50 - 25);
                newObstacle.GetComponent<Rigidbody>().velocity = new Vector3(-velocity, 0, 0);
            } else
            {
                newObstacle.transform.position = new Vector3(-width, Random.value * height * 2- height , Random.value * 50 - 25);
                newObstacle.GetComponent<Rigidbody>().velocity = new Vector3(velocity, 0, 0);
            }
        }
    }
}
