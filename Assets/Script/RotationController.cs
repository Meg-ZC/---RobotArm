using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationController : MonoBehaviour
{
    public Slider rotation1;
    public Slider rotation2;
    public Slider rotation3;
    public Slider rotation4;
    public Slider rotation5;
    public Slider rotation6;
    // Start is called before the first frame update
    public void SaveRotations()
    {
        PlayerPrefs.SetFloat("r1", rotation1.value);
        PlayerPrefs.SetFloat("r2", rotation2.value);
        PlayerPrefs.SetFloat("r3", rotation3.value);
        PlayerPrefs.SetFloat("r4", rotation4.value);
        PlayerPrefs.SetFloat("r5", rotation5.value);
        PlayerPrefs.SetFloat("r6", rotation6.value);
    }

    public void LoadRotations()
    {
        if(PlayerPrefs.HasKey("r1"))
        {
            rotation1.value = PlayerPrefs.GetFloat("r1");
            rotation1.value = PlayerPrefs.GetFloat("r2");
            rotation1.value = PlayerPrefs.GetFloat("r3");
            rotation1.value = PlayerPrefs.GetFloat("r4");
            rotation1.value = PlayerPrefs.GetFloat("r5");
            rotation1.value = PlayerPrefs.GetFloat("r6");
        }
    }
}
