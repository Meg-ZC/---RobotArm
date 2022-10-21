using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotArm1 : CommonBehavior
{
    void Start()
    {
        upperBound = 0.7f;
        lowerBound = 0;
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
