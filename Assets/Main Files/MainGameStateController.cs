using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainGameStateController : MonoBehaviour {


    public Text scoreText;
    public float time = 0f;
    public static int score = 0;
	public static float difficulty = 0;

	// Use this for initialization
	void Start () {
		difficulty = PaddleScript.difficulty;
		time = PaddleScript.timerFromMainScene;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        score = Mathf.RoundToInt(time);
        scoreText.text = "Score: " + score;
	}
}
