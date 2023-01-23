using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCanv : MonoBehaviour
{
    public Canvas Canv;

    void Start()
    {
        Canv.GetComponent<Canvas>().enabled = false;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // trigger canv
            StopAllCoroutines();
            StartCoroutine(ShowCanv(Canv, 20f));
        }
    }

    IEnumerator ShowCanv(Canvas canvas, float delay)
    {
        Debug.Log("Enable instruct canv");
        Canv.GetComponent<Canvas>().enabled = true;
        yield return new WaitForSeconds(delay);
        Canv.GetComponent<Canvas>().enabled = false;
    }
}
