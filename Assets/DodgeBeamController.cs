﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeBeamController : MonoBehaviour {

    private Transform indicator;
    private Transform beam;

    public float beamTimer = 1.5f;
    public float timeAlive = 5f;
    private bool beamShown = false;
    private float timer;

	// Use this for initialization
	void Start () {
        indicator = transform.Find("BeamIndicator");
        beam = transform.Find("Cylinder");
        
        beam.GetComponent<Renderer>().enabled = false;
        
        transform.eulerAngles = new Vector3(0, 0, Random.value * 360);
        beamShown = false;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(!beamShown && timer > beamTimer)
        {
            beam.GetComponent<Renderer>().enabled = true;
            beamShown = true;
        }

        if(timer > timeAlive)
        {
            //Debug.Log("dyin");
            Destroy(gameObject);
        }
	}
}
