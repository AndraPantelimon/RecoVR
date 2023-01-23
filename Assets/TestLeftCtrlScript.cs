using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLeftCtrlScript : MonoBehaviour
{
    public ParticleSystem ps;
    public AudioSource magic;
    private int m = 0;

    IEnumerator WaitTime(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("wait");
    }
    public void MagicOn()
    {
        StopAllCoroutines();
        StartCoroutine(WaitTime(2f));

        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger, OVRInput.Controller.Touch))
        {
            // turn on particle system
            Debug.Log("magic!");
            ps.Play();
            magic.Play();
        }
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger, OVRInput.Controller.Touch)) // 
        {
            m = 1;
            Debug.Log(m);
        }
    }
}
