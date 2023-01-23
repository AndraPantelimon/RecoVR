using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    public void ResetScene()
    {
        if (Input.GetKeyDown("esc"))
        {
            Debug.Log("reset");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
