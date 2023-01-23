using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEx4Canvas : MonoBehaviour
{
    public Canvas triggerCanv;
    public GameObject plane;
    //public GameObject screen;

    void Start()
    {
        Debug.Log("Disable Ex4 Canvas & plane");
        triggerCanv.GetComponent<Canvas>().enabled = false;
        plane.SetActive(false);
        //screen.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Robo")
        {
            Debug.Log("Activate Ex4 Canvas");
            triggerCanv.GetComponent<Canvas>().enabled = true;
            plane.SetActive(true);
            //screen.SetActive(true);
        }
    }
}
