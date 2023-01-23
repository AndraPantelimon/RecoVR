using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableRays : MonoBehaviour
{
    public GameObject rayBlocker;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tile")
        {
            // enable raycasting
            Debug.Log("Enable rays.");
            rayBlocker.SetActive(false);
        }
    }
}
