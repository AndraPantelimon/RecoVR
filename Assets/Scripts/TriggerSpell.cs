using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpell : MonoBehaviour
{
    public AudioSource sound;
    public Animator anim;
    public Canvas Canv;

    void Start()
    {
        Canv.GetComponent<Canvas>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Start Spell");
            // play spell sound
            sound.Play();
            // fade particle system to transparent
            anim.SetBool("triggered", true);
            // trigger canvas
            StopAllCoroutines();
            StartCoroutine(ShowCanv(Canv, 2f, 30f));
        }
    }

    IEnumerator ShowCanv(Canvas canvas, float delay1, float delay2)
    {
        Debug.Log("Enable instruct canv");
        yield return new WaitForSeconds(delay1);
        Canv.GetComponent<Canvas>().enabled = true;
        yield return new WaitForSeconds(delay2);
        Canv.GetComponent<Canvas>().enabled = false;
    }
}
