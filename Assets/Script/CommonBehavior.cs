using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class CommonBehavior : MonoBehaviour
{
    public char direction;//
    public float originRotation;//
    public GameObject rotationRelatePos;//
    public int sign = 1;//
    public float upperBound = 0;//
    public float lowerBound = 0;//
    public float boundDiff = 0;//
    public float target = 0;//target定义域为（0，1）//
    public float rotateVelocity = 200;

    //提供旋转角度和旋转方向，绕rotationRelatePos旋转Obj
    public void RotateObj(float angle,char dir)
    {
        float differenceAngle = angle + originRotation;//originRotation要在start设置好，且为对应方向的rotation
        Vector3 dire = Vector3.back;//不写会报错，可以为空
        switch (dir)
        {
            case 'x':
                differenceAngle -= transform.rotation.x;//
                //经测试，如果differenceAngle没有originrotation这个偏移量的话，angle为0时也会转
                // sign = angle <= (originRotation - transform.rotation.x) ? -1 : 1;//
                dire = rotationRelatePos.transform.right;
                
                break;
            case 'y':
                differenceAngle -= transform.rotation.y;
                // sign = angle <= (originRotation - transform.rotation.y) ? -1 : 1;
                dire =  rotationRelatePos.transform.forward;
                
                break;
            case 'z':
                differenceAngle -= transform.rotation.y;
                // sign = angle <= (originRotation - transform.rotation.z) ? -1 : 1;
                dire =  rotationRelatePos.transform.up;
                
                break;
            default:
                Debug.Log("None");
                break;
        }
        if (Math.Abs(differenceAngle) > 0.005f)
        {
            transform.RotateAround(rotationRelatePos.transform.position, dire,sign*Time.deltaTime*rotateVelocity*differenceAngle);//效果很像PID但不是PIDhhh
            Debug.Log(dir);
        }
    }
    // //移动物体的时候RotateAround不能保持半径
    // public void KeepDistance()
    // {
    //     float realDistance = (rotationRelatePos.transform.position - transform.position).magnitude;
    //     Vector3 vectorBetween = transform.position - rotationRelatePos.transform.position ;
    //     transform.position = rotationRelatePos.transform.position + (distance / realDistance) * vectorBetween;
    // }
}
    