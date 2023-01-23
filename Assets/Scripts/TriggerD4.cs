using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerD4 : MonoBehaviour
{
    public Animator anim;
    public static bool atLocation = false;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // animate friend entery into plane - "flies in" from the side, then text appears (not for intro)
            Debug.Log("Player entered trigger area. Show friend.");
            anim.SetBool("start", true);
            // trigger dialogue
            Debug.Log("Dialogue should start.");
            FindObjectOfType<DialogueTrigger4>().TriggerDialogue();
            atLocation = true;
            print("atLocation, "+ atLocation);
        }
    }
}