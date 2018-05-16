using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DodgeTimerController : MonoBehaviour {

    public float timer = 10f;

    public Text txt;
	float timerFromMainScene;
	float difficulty;

	// Use this for initialization
	void Start () {
		timerFromMainScene = MainGameStateController.score;
		difficulty = MainGameStateController.difficulty;
        timer = timer * difficulty;
        txt.text = Mathf.RoundToInt(timer).ToString();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        txt.text = Mathf.RoundToInt(timer).ToString();
        if (timer < 0)
        {
			PaddleScript.difficulty = difficulty;
			PaddleScript.timerFromMainScene = timerFromMainScene;
            SceneManager.LoadScene("main");
        }
    }
}
