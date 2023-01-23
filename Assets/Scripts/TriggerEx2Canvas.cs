using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEx2Canvas : MonoBehaviour
{
    public Canvas triggerCanv;
    public GameObject screen;

    void Start()
    {
        Debug.Log("Disable Canvas");
        triggerCanv.GetComponent<Canvas>().enabled = false;
        screen.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Robo")
        {
            Debug.Log("Activate Canvas");
            triggerCanv.GetComponent<Canvas>().enabled = true;
            screen.SetActive(true);
        }
    }
}
