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
        highScoreText.text = "High: " + highScore;

    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        score = Mathf.RoundToInt(time);
        scoreText.text = "Score: " + score;
        Debug.Log(highScore);
        if(score > highScore)
        {
            highScoreText.text = "High: " + highScore;
        }
	}

    public static void Restart()
    {
		if(score > highScore)
		{
            highScore = score;
        }
        score = 0;
        difficulty = 0;
        PaddleScript.difficulty = 0;
        PaddleScript.timerFromMainScene = 0;
    }
}
