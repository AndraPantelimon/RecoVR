using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEx1 : MonoBehaviour
{
    public Canvas canvas;
    // reference the InputManager GameObject
    public GameObject IM;
    public GameObject screen1;
    //public GameObject screen2;

    void Start()
    {
        //Debug.Log("Disable Input Manager");
        //IM.GetComponent<InputManager>().enabled = false;
    }

    // close canvas
    public void CloseCanvas()
    {
        canvas.GetComponent<Canvas>().enabled = false;
        screen1.SetActive(false);
        //screen2.SetActive(false);
    }

    // enable teleportation
    public void EnableTeleportation()
    {
        // enable script on GameObject when button pressed
        Debug.Log("Enable Input Manager");
        IM.GetComponent<InputManager>().enabled = true;
    }
}
