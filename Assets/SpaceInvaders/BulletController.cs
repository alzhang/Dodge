using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletController : MonoBehaviour {

	int speed = -20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,transform.position.y+speed*Time.deltaTime,0);
		if (transform.position.y < -40) {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			Debug.Log ("Game Over");
			//xSpeed = 0;
			MainGameStateController.Restart();
			SceneManager.LoadScene(0, LoadSceneMode.Single);
		}
	}
}
