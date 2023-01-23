using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackTrigger : MonoBehaviour
{
    public Feedback feedback;

    public void TriggerFeedback()
    {
        FindObjectOfType<FeedbackManager>().StartFeedback(feedback);
    }
}
