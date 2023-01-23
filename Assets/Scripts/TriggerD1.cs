using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerD1 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // animate friend entery into plane - "flies in" from the side, then text appears (not for intro)
            Debug.Log("Player entered trigger area. Show friend.");
            // trigger dialogue
            Debug.Log("Dialogue should start.");
            //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        }
    }
}
