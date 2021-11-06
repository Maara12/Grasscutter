using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float RotationModifier = 200f;

   
    // Update is called once per frame
    void Update()
    {
        //Rotates the Ball
        gameObject.transform.Rotate(0f, RotationModifier * Time.deltaTime, 0f, Space.Self);
    }
}
