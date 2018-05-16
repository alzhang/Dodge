using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	float yPosition;
	public float xSpeedLimit;
	public float xSpeed;
	public static float timerFromMainScene;
	public static float difficulty;
	public GameObject bullet;
	public Transform Ships;

	// Use this for initialization
	void Start () {
		yPosition = 0;
		timerFromMainScene = MainGameStateController.score;
		difficulty = MainGameStateController.difficulty;
		//BallScript.ySpeed = 20 + 2 * difficulty;
	}

	// Update is called once per frame
	void Update () {
		if (Ships.childCount == 0) {
			PaddleScript.difficulty = difficulty;
			PaddleScript.timerFromMainScene = timerFromMainScene;
			SceneManager.LoadScene("main");
		}
		float moveHorizontal = Input.GetAxis("Horizontal");
		//Debug.Log (moveHorizontal);
		xSpeed = moveHorizontal * Time.deltaTime * xSpeedLimit;
		yPosition += xSpeed;
		yPosition = Mathf.Clamp (yPosition, -9, 9);
		Vector3 newPos = new Vector3(yPosition, -18, 0);
		transform.position = (newPos);
		if (Input.GetKeyDown ("space")) {
			var newBullet = Instantiate (bullet) as GameObject;
			newBullet.transform.position = transform.position;
			newBullet.AddComponent<PlayerBulletController>();
		}
	}
}
