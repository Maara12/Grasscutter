using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public GameObject gameOverCanvas;
    GameOverHud Gohud;

    // Start is called before the first frame update
    void Start()
    {
        Gohud = gameOverCanvas.GetComponent<GameOverHud>();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "GameOverTrigger")
        {
            //checks for the mouse input in the gameOverTrigger Zone
            // for sending info to display Game OverHud and to destroy the Cutters
            if(Input.GetMouseButtonDown(0))
            {
                Gohud.DisplayGameOverHud(1);
                Destroy(gameObject);
            }
           
        }
    }
}
