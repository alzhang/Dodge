using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {

	public static float ySpeed;
	public Transform blocksContainer;
	float xSpeed = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(Time.deltaTime * xSpeed * 30, Time.deltaTime * ySpeed,0));
		if ((transform.position.x) > 10) {
			transform.position = new Vector3(9, transform.position.y, 0);
		}
		if ((transform.position.x) < -10) {
			transform.position = new Vector3(-9, transform.position.y, 0);
		}
		if ((transform.position.y) > 10) {
			transform.position = new Vector3(transform.position.x, 9, 0);
		}

	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Collided");
		if (other.gameObject.CompareTag("Block"))
		{
			ySpeed = -ySpeed;
			Debug.Log ("Collided with a block");
			Destroy (other.gameObject);
			Debug.Log (blocksContainer.childCount);
			if (blocksContainer.childCount == 1) {
				SceneManager.LoadScene (0, LoadSceneMode.Single);
			}
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
			//xSpeed = 0;
			PaddleScript.difficulty = 0;
			PaddleScript.timerFromMainScene = 0;
			SceneManager.LoadScene(1, LoadSceneMode.Single);
		}
	}

}
