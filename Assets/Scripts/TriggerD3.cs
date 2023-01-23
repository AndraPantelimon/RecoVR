using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerD3 : MonoBehaviour
{
    public Animator anim;
    public GameObject rayBlocker;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tile")
        {
            // animate friend entery into plane - "flies in" from the side, then text appears (not for intro)
            Debug.Log("Player entered trigger area. Show friend.");
            anim.SetBool("cont", true);
            // trigger dialogue
            Debug.Log("Dialogue should start.");
            FindObjectOfType<DialogueTrigger3>().TriggerDialogue();
            rayBlocker.SetActive(false);
        }
    }
}