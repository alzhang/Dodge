using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlaneController : MonoBehaviour {

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject,2);
        }
    }
}
