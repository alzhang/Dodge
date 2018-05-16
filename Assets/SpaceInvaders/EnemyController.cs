using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	float difficulty = MainGameStateController.difficulty;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int randomInt = Random.Range (0, (int) (Mathf.Clamp(11-difficulty,1,10)/Time.deltaTime/3f));
		if (randomInt == 0) {
			var newBullet = Instantiate (bullet) as GameObject;
			newBullet.transform.position = transform.position;
			newBullet.AddComponent<BulletController>();
		}
	}
}
