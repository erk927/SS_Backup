using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool isPaused;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M) && !isPaused)
        {
            PauseGame();
        }
        if(Input.GetKeyDown(KeyCode.M) && isPaused)
        {
            ResumeGame();
        }
    }

    void PauseGame ()
    {
        Time.timeScale = 0;
        isPaused = true;
    }

    void ResumeGame ()
    {
        Time.timeScale = 1;
        isPaused = false;
    }
}
