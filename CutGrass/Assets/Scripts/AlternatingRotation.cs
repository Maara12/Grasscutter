using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternatingRotation : MonoBehaviour
{
    public Transform BallA;
    public Transform BallB;
    public Transform Connector;

    bool isParentBallA = true;

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //change parent ball if parent ball is A
            if(isParentBallA)
            {
                ChangeParentBall(BallA, Connector, BallB);
                isParentBallA = false;
            }
            else
            {
                //else change parent to ball B
                ChangeParentBall(BallB, Connector, BallA);
                isParentBallA = true;
            }
            
        }
    }

    //changes parent ball based on mouse input to create the
    //alternating rotating motion
    private void ChangeParentBall(Transform parentball, Transform connector, Transform childball)
    {
        parentball.DetachChildren();
        parentball.parent = childball;
        connector.parent = childball;
        
    }
}
