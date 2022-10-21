using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : CommonBehavior
{
    
    void Start()
    {
        upperBound = 0.7f;
        lowerBound = 0;
        originRotation = transform.rotation.x;
        direction = 'x';
        boundDiff = upperBound - lowerBound;
        sign = 1;
    }

    private void Update()
    {
        RotateObj(target * boundDiff,direction);
        Debug.Log(transform.rotation);
    }
    // Update is called once per frame
}
