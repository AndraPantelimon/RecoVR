using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerD2 : MonoBehaviour
{
    //public GameObject IM;
    //public SpriteRenderer navTarget;
    public Animator anim;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // animate friend entery into plane - "flies in" from the side, then text appears (not for intro)
            Debug.Log("Player entered trigger area. Show friend.");
            anim.SetBool("start", true);
            // trigger dialogue
            //Debug.Log("TriggerD2 works. Dialogue 2 should start.");
            FindObjectOfType<DialogueTrigger2>().TriggerDialogue();
        }
    }
}
