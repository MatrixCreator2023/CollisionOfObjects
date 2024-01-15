using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTryger : MonoBehaviour
{
    

    float speedFactor = 10.5f;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;

        //script.speed = speedFactor;
    }
    
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
    
}