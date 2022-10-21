using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.UI;

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
    public Slider slider;
    private float k = 0, b = 0;//函数两个参数

    //提供旋转角度和旋转方向，绕rotationRelatePos旋转Obj
    public void RotateObj(float angle,char dir)
    {
        angle = Math.Max(-upperBound, Math.Min(upperBound, angle));//设置范围
        float differenceAngle = angle + originRotation;//originRotation要在start设置好，且为对应方向的rotation
        Vector3 dire = Vector3.back;//不写会报错，可以为空
        switch (dir)
        {
            case 'x':
                differenceAngle -= transform.localRotation.x;//
                //经测试，如果differenceAngle没有originrotation这个偏移量的话，angle为0时也会转
                // sign = angle <= (originRotation - transform.rotation.x) ? -1 : 1;//
                dire = rotationRelatePos.transform.right;
                
                break;
            case 'y':
                differenceAngle -= transform.localRotation.z;
                // sign = angle <= (originRotation - transform.rotation.y) ? -1 : 1;
                dire =  rotationRelatePos.transform.forward;
                //因为模型导出的方向和unity的不一样，所以轴向不同
                break;
            case 'z':
                differenceAngle -= transform.localRotation.y;
                // sign = angle <= (originRotation - transform.rotation.z) ? -1 : 1;
                dire =  rotationRelatePos.transform.up;
                
                break;
            default:
                Debug.Log("None");
                break;
        }
        if (Math.Abs(differenceAngle) > 0.0005f)
        {
            transform.RotateAround(rotationRelatePos.transform.position, dire,sign*Time.deltaTime*rotateVelocity*differenceAngle);//效果很像PID但不是PIDhhh
            Debug.Log(dir);
        }
    }

    public void ParamaterSetter(float lowBound,float upperBound)//输入范围和滑块初始位置，将滑块之后的value与值域对应
    {
        k = upperBound - lowBound;
        b = lowBound;
    }

    public void TargetUpdate()
    {
        target = slider.value * k + b;
    }
    // //移动物体的时候RotateAround不能保持半径
    // public void KeepDistance()
    // {
    //     float realDistance = (rotationRelatePos.transform.position - transform.position).magnitude;
    //     Vector3 vectorBetween = transform.position - rotationRelatePos.transform.position ;
    //     transform.position = rotationRelatePos.transform.position + (distance / realDistance) * vectorBetween;
    // }
}
    