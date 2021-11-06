using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHud : MonoBehaviour
{
    public GameObject GameOverCanvas;

    public void DisplayGameOverHud(int value)
    {
        if(value == 1)
        {
            GameOverCanvas.SetActive(true);
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
    }
}
