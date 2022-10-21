using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotArm2 : CommonBehavior
{
    void Start()
    {
        upperBound = 0.66f;
        lowerBound = -upperBound;
        originRotation = transform.localRotation.x;
        direction = 'x';
        boundDiff = upperBound - lowerBound;
        ParamaterSetter(lowerBound,upperBound);
    }

    private void Update()
    {
        TargetUpdate();
        RotateObj(target * boundDiff,direction);
        // Debug.Log(transform.rotation);
    }
}
