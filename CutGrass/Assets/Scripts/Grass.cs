using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    public GameObject HUD;
    ScoreUpdate ScoreUpdateScript;
    const float ScorePoint = 1;

    // Start is called before the first frame update
    void Start()
    {
        ScoreUpdateScript = GameObject.FindGameObjectWithTag("HUD").GetComponent<ScoreUpdate>();
    }
        
    private void OnTriggerStay(Collider other)
    {
        //checks if cutters make contact with grass and sends score point to
        //scoreUpdate script in HUDCanvas
        if(other.gameObject.tag == "Cutters")
        {
            ScoreUpdateScript.Addpoints(ScorePoint);
            Destroy(gameObject);
        }
    }
}
