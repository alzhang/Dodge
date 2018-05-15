using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MainGameStateController : MonoBehaviour {


    public Text scoreText;
    public Text highScoreText;
    public float time = 0f;
    public static int score = 0;
    public static int highScore = 0;
	public static float difficulty = 0;
    

	// Use this for initialization
	void Start () {
		difficulty = PaddleScript.difficulty;
		time = PaddleScript.timerFromMainScene;
        highScoreText.text = "High Score: 0";

    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        score = Mathf.RoundToInt(time);
        scoreText.text = "Score: " + score;
        if(score > highScore)
        {
            highScoreText.text = "High Score: " + highScore;
        }
	}

    public static void Restart()
    {
        if(score > highScore)
        {
            highScore = score;
            score = 0;
            difficulty = 0;
            Debug.Log("restaring");
        }
    }
}
