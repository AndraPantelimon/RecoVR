using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundAndra : MonoBehaviour
{
    public AudioSource objAudio;
    // Start is called before the first frame update
    void playSound()
    {
        objAudio.Play();
    }
}
