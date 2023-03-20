using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gyroattitude : MonoBehaviour
{
    Gyroscope m_Gyro;
    Text input;

    void Start()
    {
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
        input = GetComponent<Text>();
    }

    
    void Update()
    {
        input.text = "Gyro attitude" + m_Gyro.attitude;
    }
}
