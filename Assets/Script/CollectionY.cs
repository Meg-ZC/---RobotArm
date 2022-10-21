using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionY : CommonBehavior
{
    void Start()
    {
        upperBound = 1f;
        lowerBound = 0;
        originRotation = transform.rotation.y;
        direction = 'y';
        boundDiff = upperBound - lowerBound;
    }

    private void Update()
    {
        RotateObj(target * boundDiff,direction);
        Debug.Log(transform.rotation);
    }
}
