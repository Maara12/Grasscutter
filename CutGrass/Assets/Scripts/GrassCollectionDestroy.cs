using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassCollectionDestroy : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //destroys the grass collection if the children is null 
        //(i.e. grass in grass collection)
        if (gameObject.transform.childCount == 0)
        {
            Destroy(gameObject);
        }
    }
}
