using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex4Manager : MonoBehaviour
{
    public Canvas canvas; // instructions
    public GameObject plane; // plane behind instrucitons canvas
    public Canvas UI; // UI for feedback during exercise

    public TMP_Text curr_rep;
    public TMP_Text target_reps;
    public TMP_Text feedbackText;

    //public GameObject IM; // input manager
    //public SpriteRenderer navTarget;
    public Animator anim;
    public GameObject EField;
    public GameObject rayBlocker;

    public ParticleSystem ps;
    public ParticleSystem boom;
    public AudioSource magic;
    // private int mag_on = 0;

    private static int reps = 0;
    private int target = 10;

    void Start()
    {
        UI.GetComponent<Canvas>().enabled = false;
        target_reps.text = target.ToString();
        feedbackText.enabled = false;
    }

    public void HandleUI()
    {
        canvas.GetComponent<Canvas>().enabled = false;
        plane.SetActive(false);
        UI.GetComponent<Canvas>().enabled = true;
    }

    IEnumerator ShowText(string text, float delay)
    {
        Debug.Log(text);
        feedbackText.text = text;
        // feedbackText.color = new Color(60, 179, 113); // bright orange
        feedbackText.enabled = true;
        yield return new WaitForSeconds(delay);
        feedbackText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // if secondary (left) trigger pressed
        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger, OVRInput.Controller.Touch))
        {
            if (TriggerD4.atLocation == true)
            {
                // turn on particle system
                Debug.Log("pressed left index trigger");
                ps.Play();
                magic.Play();
            }
        }

        //  if key pressed
        if (Input.GetKeyDown("w"))
        {
            if (reps < 10)
            {
                reps++;
                print("reps: " + reps);
                // show reps on UI
                curr_rep.text = reps.ToString();
                // anim
                anim.Play("eField_damage");
                boom.Play();
                //anim.SetBool("hit", true); // play field damage
            }
            else if (reps == 10)
            {
                // turn off magic particle system
                ps.Stop(); // includeChildren, ParticleSystemStopBehavior.StopEmittingAndClear
                magic.Stop();
                // destroy e field
                EField.SetActive(false);
                // enable raycasting
                rayBlocker.SetActive(false);
                UI.GetComponent<Canvas>().enabled = false;
            }
            anim.SetBool("hit", false); // cannot play field damage
        }

        // feedback
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Debug.Log("Show fdbk1");
            StopAllCoroutines();
            StartCoroutine(ShowText("Keep your knee as straight as possible.", 5f));
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Debug.Log("Show fdbk2");
            StopAllCoroutines();
            StartCoroutine(ShowText("Don't lift your leg so high.", 5f));
        }
    }

    /*public void MagicOn()
    {
        // yield return new WaitForSeconds(1.5f);
        // if secondary (left) trigger pressed
        if (mag_on == 1) // 
        {
            if (TriggerD4.atLocation == true)
            {
                // turn on particle system
                Debug.Log("pressed left index trigger");
                ps.Play();
                magic.Play();
            }
        }*/
}
