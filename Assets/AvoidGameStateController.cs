using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvoidGameStateController : MonoBehaviour {

	private float timer = 10;

    public Text timerText;
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        timerText.text = "Timer: " + Mathf.RoundToInt(timer);

        if(timer < 0)
        {
            
        }
	}
}
