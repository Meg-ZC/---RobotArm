using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControl : CommonBehavior
{
    // Start is called before the first frame update
    void Start()
    {
        upperBound = 0.3f;
        lowerBound = -upperBound;
        originRotation = transform.rotation.z;
        direction = 'z';
        boundDiff = upperBound - lowerBound;
        ParamaterSetter(lowerBound,upperBound);
    }

    // Update is called once per frame
    void Update()
    {
        TargetUpdate();
        RotateObj(target * boundDiff,direction);
        // Debug.Log(transform.rotation);
    }
}
