using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionY : CommonBehavior
{
    void Start()
    {
        upperBound = 1f;
        lowerBound = -upperBound;
        originRotation = transform.localRotation.y;
        direction = 'y';
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
