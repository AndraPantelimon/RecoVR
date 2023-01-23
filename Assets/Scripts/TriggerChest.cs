using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChest : MonoBehaviour
{
    public Animator chest;
    public Animator robo;
    public ParticleSystem guardian;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Open Chest");
            chest.SetBool("open", true);
            guardian.Play();
            StopAllCoroutines();
            StartCoroutine(EnterRobo());
        }
    }
    // wait to enter
    IEnumerator EnterRobo()
    {
        yield return new WaitForSeconds(4f);
        robo.SetBool("fin", true);
        FindObjectOfType<DialogueTrigger5>().TriggerDialogue();
    }
}
