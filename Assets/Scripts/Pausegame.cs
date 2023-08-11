using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausegame : MonoBehaviour
{
    private bool isPause;
    public GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!isPause)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }
            isPause = !isPause;
        }
    }
}
