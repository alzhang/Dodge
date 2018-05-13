using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {


    public GameObject beam;

    public float frequency = .05f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Random.value < frequency)
        {
            //spawn an indicator

        }
	}
}
