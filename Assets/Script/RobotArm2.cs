using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotArm2 : CommonBehavior
{
    void Start()
    {
        upperBound = 0.66f;
        lowerBound = 0;
        originRotation = transform.rotation.x;
        direction = 'x';
        boundDiff = upperBound - lowerBound;
    }

    private void Update()
    {
        RotateObj(target * boundDiff,direction);
        Debug.Log(transform.rotation);
    }
}
