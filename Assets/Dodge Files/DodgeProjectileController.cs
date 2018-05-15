using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeProjectileController : MonoBehaviour {


    public GameObject beam;

    public float frequency = .05f;

	// Use this for initialization
	void Start () {
        int difficulty = MainGameStateController.score;
	}
	
	// Update is called once per frame
	void Update () {
		if(Random.value < frequency)
        {
            GameObject child = Instantiate(beam);
            child.transform.position = new Vector3(0, 0, -10);
            //spawn an indicator

        }
	}
}
