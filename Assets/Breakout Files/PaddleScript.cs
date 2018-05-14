using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	float yPosition;
	public float xSpeedLimit;
	public float xSpeed;

	// Use this for initialization
	void Start () {
		yPosition = 0;
		xSpeed = 0;
	}

	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		Debug.Log (moveHorizontal);
		xSpeed = moveHorizontal * Time.deltaTime * xSpeedLimit;
		yPosition += xSpeed;
		yPosition = Mathf.Clamp (yPosition, -8, 8);
		Vector3 newPos = new Vector3(yPosition, -18, 0);
		transform.position = (newPos);
	}
}
