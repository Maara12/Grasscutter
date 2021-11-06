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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //change parent ball
            if(isParentBallA)
            {
                Debug.Log("inputReceived");
                ChangeParentBall(BallA,Connector,BallB);
                isParentBallA = false;
            }
            else
            {
                ChangeParentBall(BallB, Connector, BallA);
                isParentBallA = true;
            }
            
        }
    }

    private void ChangeParentBall(Transform parentball, Transform connector, Transform childball)
    {
        parentball.DetachChildren();
        parentball.parent = childball;
        connector.parent = childball;
        
    }
}
