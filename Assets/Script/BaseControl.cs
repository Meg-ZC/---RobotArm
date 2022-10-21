using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControl : CommonBehavior
{
    // Start is called before the first frame update
    void Start()
    {
        upperBound = 0.2f;
        lowerBound = 0;
        originRotation = transform.rotation.y;
        direction = 'y';
        boundDiff = upperBound - lowerBound;
    }

    // Update is called once per frame
    void Update()
    {
        RotateObj(target * boundDiff,direction);
        Debug.Log(transform.rotation);
    }
}
