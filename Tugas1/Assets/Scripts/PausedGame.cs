using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedGame : MonoBehaviour
{
    bool paused = false;

    public void pauseGame()
    {
        if (paused)
        {
            Time.timeScale = 0f;
            paused = false;
        }
        else
        {
            Time.timeScale = 1f;
            paused = true;
        }
    }
}
