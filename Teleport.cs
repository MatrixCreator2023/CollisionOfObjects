using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform telepotPoint;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Transform>().position = telepotPoint.position;
    }
}
