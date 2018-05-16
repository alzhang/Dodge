using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPlayerController : MonoBehaviour {

	public float sideSpeed = .5f;
	public float lossHeight = -5f;
	public float forwardSpeed = 2f;
	float pauseTimer = 0f;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		float movement = Input.GetAxis ("Horizontal");

		if (pauseTimer < 1f) {
			pauseTimer += Time.deltaTime;
		} else {


			//rb.velocity = new Vector3(movement * sideSpeed, rb.velocity.y, forwardSpeed);

			transform.position = transform.position + new Vector3 (movement * sideSpeed, 0, forwardSpeed);

			if (transform.position.y < lossHeight) {
                Debug.Log("restarting");
				MainGameStateController.Restart();
                Debug.Log("exit restart");
				SceneManager.LoadScene(0, LoadSceneMode.Single);
			}
		}

	}
	void OnTriggerEnter(Collider other)
	{
		MainGameStateController.difficulty++;
		SceneManager.LoadScene(Random.Range(1,4), LoadSceneMode.Single);
		//GameObject.Find("GameState").GetComponent<MainGameStateController>().difficulty++;
		Debug.Log("Collision!");
	}
}
