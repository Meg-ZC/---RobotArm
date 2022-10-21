using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotArm1 : CommonBehavior
{
    void Start()
    {
        upperBound = 0.7f;
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
