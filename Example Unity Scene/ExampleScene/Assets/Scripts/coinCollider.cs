using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") //if the coins collides with an object that is tagged "Player"
        {
            SceneManager.LoadScene(0); //change the scene to index 0 scene
        }
    }
}
