using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipsController : MonoBehaviour {

	float difficulty = MainGameStateController.difficulty;
	float speed = 1;

	// Use this for initialization
	void Start () {
		speed = 2*Mathf.Clamp(difficulty,1,10);
	}
	
	// Update is called once per frame
	void Update () {
		float xPosition = transform.position.x + speed * Time.deltaTime;
		if(xPosition < -1 || xPosition > 8){
			xPosition = Mathf.Clamp(xPosition,-1,8);
			speed = -speed;
		}
		transform.position = new Vector3(xPosition,transform.position.y,transform.position.z);
	}
}
