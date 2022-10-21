using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionZ : CommonBehavior
{
    void Start()
    {
        upperBound = 0.45f;
        lowerBound = -upperBound;
        originRotation = transform.localRotation.z;
        direction = 'z';
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