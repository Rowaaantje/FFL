using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stepcounter : MonoBehaviour
{
    Gyroscope m_Gyro;
    Text input;
    int intCounter = 0;
    float timer = 0;
    int margin = 27;

    private void Start()
    {
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
        input = GetComponent<Text>();

        if (PlayerPrefs.HasKey("stepcounter"))
        {
            intCounter = PlayerPrefs.GetInt("stepcounter", 0);
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if ((m_Gyro.userAcceleration.y * 100) > margin && timer >= 0.5f)
        {
			intCounter = PlayerPrefs.GetInt("stepcounter", 0);
			intCounter++;
            timer = 0;
            PlayerPrefs.SetInt("stepcounter", intCounter);
            PlayerPrefs.Save();
        }

        input.text = "" + intCounter;
    }

    void OnApplicationQuit()
    {
		PlayerPrefs.Save();
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