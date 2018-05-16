using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AvoidGameStateController : MonoBehaviour {

	private float timer = 10;

    public Text timerText;

    float timerFromMainScene;
    float difficulty;

    private void Start()
    {

        timerFromMainScene = MainGameStateController.score;
        difficulty = MainGameStateController.difficulty;
        timer = timer * difficulty;
    }

    // Update is called once per frame
    void Update () {
        timer -= Time.deltaTime;
        timerText.text = "Timer: " + Mathf.RoundToInt(timer);

        if(timer < 0)
        {

            PaddleScript.difficulty = difficulty;
            PaddleScript.timerFromMainScene = timerFromMainScene;
            SceneManager.LoadScene("main");
        }
	}
}
