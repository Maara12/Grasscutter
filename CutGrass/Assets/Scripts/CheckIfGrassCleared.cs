using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfGrassCleared : MonoBehaviour
{
    bool islevelCleared = false;
    LevelClearedHud lvlclrHUD;

    public GameObject levelclearhud;

    // Start is called before the first frame update
    void Start()
    {
        lvlclrHUD = levelclearhud.GetComponent<LevelClearedHud>();
    }

    // Update is called once per frame
    void Update()
    {
        //checks if grass is cleared and sends info to levelCLearedhud
        if(gameObject.transform.childCount == 0)
        {
            islevelCleared = true;
        }

        if(islevelCleared)
        {
            lvlclrHUD.DisplayLevelCLearHud(1);
        }

    }
}
