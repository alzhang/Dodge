using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public float ySpeed = 5f;
	float xSpeed = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(xSpeed, Time.deltaTime * ySpeed,0));

	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Collided");
		if (other.gameObject.CompareTag("Block"))
		{
			ySpeed = -ySpeed;
			Debug.Log ("Collided with a block");
			Destroy (other.gameObject);
			//GetComponent<Renderer>().enabled = false;
			//GetComponent<BoxCollider>().enabled = false;
		}
		if (other.gameObject.CompareTag ("Paddle")) {
			ySpeed = -ySpeed;
			xSpeed = other.GetComponent<PaddleScript>().xSpeed;
		}
		if (other.gameObject.CompareTag("Vertical Wall")){
			Debug.Log ("Bounce!");
			xSpeed = -xSpeed;
		}
		if (other.gameObject.CompareTag ("Horizontal Wall")) {
			ySpeed = -ySpeed;
		}
		if (other.gameObject.CompareTag ("Bottom")) {
			Debug.Log ("Game Over");
			xSpeed = 0;
			ySpeed = 0;
			Application.Quit ();
		}
	}

}
