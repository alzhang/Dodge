using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class DodgePlayerController : MonoBehaviour {


    public float currentPosition = 0f;
    public float speed = 0.075f;
    public float radius = 465f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float rotation = Input.GetAxis("Horizontal");
        currentPosition += rotation*speed;

        transform.position = new Vector3(Mathf.Cos(currentPosition)*radius, Mathf.Sin(currentPosition)*radius, 0);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            //EditorApplication.isPaused = true;
            MainGameStateController.Restart();

            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
    
}
