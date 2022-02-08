using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script used to trigger the door animation.
 * 
 * @author Sami Cemek
 */

public class playAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  //Notice I'm using the Player tag not the name
            myAnimationController.SetBool("playAnim", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))  //Notice I'm using the Player tag not the name
            myAnimationController.SetBool("playAnim", false);

    }

}
