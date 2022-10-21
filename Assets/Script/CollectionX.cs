using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionX : CommonBehavior
{
    void Start()
    {
        upperBound = 0.3f;
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