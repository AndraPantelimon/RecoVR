using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex2Manager : MonoBehaviour
{
    public Canvas canvas; // instructions
    public GameObject screen; // demo screen
    public Canvas UI; // UI for feedback during exercise
    public TMP_Text curr_rep;
    public TMP_Text target_reps;
    public TMP_Text feedbackText;

    public GameObject IM; // input manager
    public SpriteRenderer navTarget;

    public Animator anim;
    public Transform bridge;

    private static int reps = 0;
    private int target = 15;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hide Path");
        anim.Play("beforeEx2");
        UI.GetComponent<Canvas>().enabled = false;

        target_reps.text = target.ToString();
        feedbackText.enabled = false;
    }

    // close canvas
    public void HandleUI()
    {
        canvas.GetComponent<Canvas>().enabled = false;
        screen.SetActive(false);
        UI.GetComponent<Canvas>().enabled = true;
    }

    // disable teleportation
    public void DisableTeleportation()
    {
        IM.GetComponent<InputManager>().enabled = false;
        navTarget.enabled = false;
    }

    IEnumerator ShowText(string text, float delay)
    {
        Debug.Log(text);
        feedbackText.text = text;
        // feedbackText.color = new Color(60, 179, 113); // bright orange
        feedbackText.enabled = true;
        yield return new WaitForSeconds(delay);
        feedbackText.enabled = false;
        // Debug.Log("TEST");
    }

    // Update is called once per frame
    void Update()
    {
        //  if key pressed
        if (Input.GetKeyDown("a"))
        {
            // increase rep count + display on screen
            if (reps < 15)
            {
                reps++;
                print("reps: " + reps);
                // show reps on UI
                curr_rep.text = reps.ToString();
                // anim
                anim.Play(reps.ToString());
            }
            else if (reps == 15)
            {
                UI.GetComponent<Canvas>().enabled = false;
            }
        }

        // feedback
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Debug.Log("Show fdbk1");
            StopAllCoroutines();
            StartCoroutine(ShowText("Keep your knee as straight as possible.", 5f));
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Debug.Log("Show fdbk2");
            StopAllCoroutines();
            StartCoroutine(ShowText("Don't lift your leg so high.", 5f));
        }
    }
}
