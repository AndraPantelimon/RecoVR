// manages relationship between Unity and Python

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommunicationManag : MonoBehaviour
{
    private bool ex1;
    private bool ex2;
    private bool ex3;
    private bool ex4;
    // Start is called before the first frame update
    void Start()
    {
        ex1 = false;
        ex2 = false;
        ex3 = false;
        ex4 = false;
    }

    public void CheckStatus()
    {
        if (ex1 == true)
        {
            // send to python
        }
        else if (ex2 == true)
        {
            // send to python
        }
        else if (ex3 == true)
        {
            // send to python
        }
        else if (ex4 == true)
        {
            // send to python
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ex1 == true)
        {
            // receive python updates
        }
        else if (ex2 == true)
        {
            // receive python updates
        }
        else if (ex3 == true)
        {
            // receive python updates
        }
        else if (ex4 == true)
        {
            // receive python updates
        }
    }
}
