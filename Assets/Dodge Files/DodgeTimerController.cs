using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DodgeTimerController : MonoBehaviour {

    public float timer = 10f;

    public Text txt;
    

	// Use this for initialization
	void Start () {
        txt.text = Mathf.RoundToInt(timer).ToString();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        txt.text = Mathf.RoundToInt(timer).ToString();
        if (timer < 0)
        {
            SceneManager.LoadScene("main");
        }
    }
}
