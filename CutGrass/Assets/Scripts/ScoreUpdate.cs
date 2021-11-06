using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text ScoreText;
    float score = 0;

    // Update is called once per frame
    void Update()
    {
        //updates the score text
        ScoreText.text = score.ToString();
    }

    public void Addpoints(float ScorePoint)
    {
        // adds score points to score text
        score += ScorePoint;
        
    }
}
