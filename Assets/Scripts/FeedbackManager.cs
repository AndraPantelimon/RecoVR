using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FeedbackManager : MonoBehaviour
{
    public TMP_Text feedbackText;
    private string[] sentences;

    void Start()
    {
        string[] sentences = new string[100];
    }

    public void StartFeedback (Feedback feedback)
    {
        Debug.Log("Give Feedback");
        /*if (Input.GetKeyDown = "1")
        {
            feedbackText.text = sentences[0];
        }
        else if (Input.GetKeyDown = "2")
        {
            feedbackText.text = sentences[1];
        }
        else if (Input.GetKeyDown = "3")
        {
            feedbackText.text = sentences[2];
        }*/
    }
}
