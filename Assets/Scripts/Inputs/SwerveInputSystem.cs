using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInputSystem : MonoBehaviour
{
    private float _lastFrameFingerPositionX;
    private float _moveFactorX;
    public float MoveFactorX => _moveFactorX;
    public float planeSize=0.8f;
    bool left;
    bool right;

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastFrameFingerPositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            _moveFactorX = Input.mousePosition.x - _lastFrameFingerPositionX;
            DecideLeftOrRight();
            ApplyForce();
            
            //Debug.Log("MoveFactorX: " + _moveFactorX);
            _lastFrameFingerPositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _moveFactorX = 0f;
        }
    }
    private void DecideLeftOrRight()
    {
       if(_moveFactorX<-5)
        {
            right = false;
            left = true;
                
        }
        else if(_moveFactorX>5)
        {
            right = true;
            left = false;

        }
        else{
            right = false;
            left = false;
        }
        
    }
    private void ApplyForce()
    {
        if (left)
        {
            float posx = Mathf.Lerp(transform.position.x, -planeSize, Time.deltaTime * 1.8f);
            transform.position = new Vector3(posx, transform.position.y, transform.position.z);
        }
        if (right)
        {

            float posx = Mathf.Lerp(transform.position.x, planeSize, Time.deltaTime * 1.8f);
            transform.position = new Vector3(posx, transform.position.y, transform.position.z);

        }
    }
}