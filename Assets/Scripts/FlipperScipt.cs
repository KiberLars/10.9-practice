using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using UnityEngine;

public class FlipperScipt : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrengh = 10000f;
    public float flipperDamper = 150f;

    public string myName;
    HingeJoint hingle;
    void Start()
    {
        hingle = GetComponent<HingeJoint>();
        hingle.useSpring = true;
    }

    void Update()
    {
        TimerHandler();
    }

    private void TimerHandler()
    {
        if (Input.GetAxis(myName) == 1)
        {
            Toogle(pressedPosition);
        }
        else
        {
            Toogle(restPosition);
        }
    }

    private void Toogle(float pos)
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrengh;
        spring.damper = flipperDamper;

        spring.targetPosition = pos;
        hingle.spring = spring;
        hingle.useLimits = true;
    }
}
