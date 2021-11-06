using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelClearedHud : MonoBehaviour
{
    public GameObject LevelClearedCanvas;

    
    public void DisplayLevelCLearHud(int value)
    {
        if (value == 1)
        {
            LevelClearedCanvas.SetActive(true);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    
}
