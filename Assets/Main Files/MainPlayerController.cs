﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerController : MonoBehaviour {

    public float sideSpeed = .5f;
    public float lossHeight = -5f;
    public float forwardSpeed = .5f;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float movement = Input.GetAxis("Horizontal");

        //rb.velocity = new Vector3(movement * sideSpeed, rb.velocity.y, forwardSpeed);
        
        transform.position = transform.position + new Vector3(movement * sideSpeed, 0, forwardSpeed);

        if(transform.position.y < lossHeight)
        {

        }
    }
}
