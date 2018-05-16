using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AvoidPlayerController : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {
        float horizontal= Input.GetAxis("Horizontal");
        float lateral = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontal, lateral, 0) * speed;

    }

    private void OnTriggerEnter(Collider other)
    {
        MainGameStateController.Restart();
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
