using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1Progress : MonoBehaviour
{
    public Canvas canvas;
    public GameObject IM;
    public SpriteRenderer navTarget;
    public GameObject screen1;
    //public GameObject screen2;
    // Start is called before the first frame update
    void Start()
    {
        IM.GetComponent<InputManager>().enabled = false;
        screen1.SetActive(false);
        //screen2.SetActive(false);
    }

    // close canvas
    public void CloseCanvas()
    {
        canvas.GetComponent<Canvas>().enabled = false;
        screen1.SetActive(false);
        //screen2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canvas.GetComponent<Canvas>().enabled == false) // (canvas == null)
            {
            // if receiving ok from python
            if (Input.GetKey("space"))
            {
                Debug.Log("Space key pressed. Enable Input Manager");
                // enable script on GameObject when button pressed
                IM.GetComponent<InputManager>().enabled = true;
                navTarget.enabled = true;
            }
            else
            {
                // disable teleportation
                IM.GetComponent<InputManager>().enabled = false;
                navTarget.enabled = false;

            }
        }
    }
}
