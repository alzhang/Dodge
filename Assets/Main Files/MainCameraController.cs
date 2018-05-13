using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour {

    private Vector3 offset;
    public GameObject player;

	// Use this for initialization
	void Start () {
        offset = player.transform.up * 2 + player.transform.forward * -4;
        transform.position = player.transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform);
	}
}
