using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager4 : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public Animator anim;
    public Canvas diagBox;

    private Queue<string> sentences;

    // Use this for initialization
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        nameText.text = dialogue.name;

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        Debug.Log("sentence count at diag start: " + sentences.Count);
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        //dialogueText.text = sentence;
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        Debug.Log("End.");
        // Close App
        diagBox.GetComponent<Canvas>().enabled = false;
        // quit a build
        // Application.Quit();
        // quit Editor simulation
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
