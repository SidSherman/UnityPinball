using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private HingeJoint[] _wheels;
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        // target velocity не меняется поэтому не получается поменять скорость
        Movement();
    }

    void Movement()
    {
        float forward = Mathf.RoundToInt(Input.GetAxis("Vertical"));
        
        if (forward == 0)
        {
            foreach (HingeJoint wheel in _wheels)
            {
                wheel.useMotor = false;
            }
        }
        else if (forward > 0)
        {
            foreach (HingeJoint wheel in _wheels)
            {
                wheel.useMotor = true;
                var motor = wheel.motor;
                // target velocity не меняется
                motor.targetVelocity = _speed;
            }
        }
        else if (forward < 0)
        {
            foreach (HingeJoint wheel in _wheels)
            {
                wheel.useMotor = true;
                var motor = wheel.motor;
                
                motor.targetVelocity = -_speed;
            }
        }
       
    }
}