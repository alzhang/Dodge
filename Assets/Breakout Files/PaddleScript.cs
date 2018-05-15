using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	float yPosition;
	public float xSpeedLimit;
	public float xSpeed;
	public static float timerFromMainScene;
	public static float difficulty;

	// Use this for initialization
	void Start () {
		yPosition = 0;
		timerFromMainScene = MainGameStateController.score;
		difficulty = MainGameStateController.difficulty;
		transform.localScale = new Vector3(Mathf.Clamp(10 - difficulty,1,10), .5f, 1f);
		BallScript.ySpeed = 20 + 2 * difficulty;
	}

	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		//Debug.Log (moveHorizontal);
		xSpeed = moveHorizontal * Time.deltaTime * xSpeedLimit;
		yPosition += xSpeed;
		yPosition = Mathf.Clamp (yPosition, -10 + Mathf.Clamp(10 - difficulty,1,10)/2, 10-Mathf.Clamp(10 - difficulty,1,10)/2);
		Vector3 newPos = new Vector3(yPosition, -18, 0);
		transform.position = (newPos);
	}
}
