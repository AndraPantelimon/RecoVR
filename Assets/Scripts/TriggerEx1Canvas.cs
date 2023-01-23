using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEx1Canvas : MonoBehaviour
{
    public Canvas triggerCanv;
    public GameObject screen1;
    //public GameObject screen2;

    void Start()
    {
        Debug.Log("Disable Canvas");
        triggerCanv.GetComponent<Canvas>().enabled = false;
        screen1.SetActive(false);
        //screen2.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Robo")
        {
            Debug.Log("Activate Canvas");
            triggerCanv.GetComponent<Canvas>().enabled = true;
            screen1.SetActive(true);
            //screen2.SetActive(true);
        }
    }
}
