using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stepcounter : MonoBehaviour
{
    Gyroscope m_Gyro;
    Text input;
    int intCounter;
    float timer = 0;
    int margin = 27;

    private void Start()
    {
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
        input = GetComponent<Text>();
        PlayerPrefs.GetInt("stepcounter", intCounter);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if ((m_Gyro.userAcceleration.y * 100) > margin && timer >= 0.5f)
        {
            intCounter++;
            Debug.Log(intCounter);
            timer = 0;
            PlayerPrefs.SetInt("stepcounter", intCounter);
        }

        input.text = "" + intCounter;
    }
}

//public class stepcounter : MonoBehaviour
//{
//	Gyroscope m_Gyro;
//	Text input;
//	//int intCounter = 0;
//	float timer = 0;
//	int margin = 27;

//	void Start()
//	{
//		m_Gyro = Input.gyro;
//		m_Gyro.enabled = true;
//		input = GetComponent<Text>();
//	}

//	void Update()
//	{
//		timer += Time.deltaTime;
//		if ((m_Gyro.userAcceleration.y * 100) > margin && timer >= 0.5f)
//		{
//			intCounter++;
//			timer = 0;
//		}



//		input.text = "" + intCounter;
//		//TextMeshProUGUI
//	}  
//}