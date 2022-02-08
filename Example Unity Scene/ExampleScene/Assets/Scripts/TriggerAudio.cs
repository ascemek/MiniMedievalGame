using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script is checking if "Player" tagged object enters
 * the character's trigger zone.
 * 
 * @author Sami Cemek
 */

public class TriggerAudio : MonoBehaviour {

    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.tag == "Player") //if an object tagged "Player" enters the trigger zone
        {
            audioSource.Play();                //play an audio
        }
    }
}
