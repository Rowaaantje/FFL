using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxWo : MonoBehaviour
{
    public int MaxNum;

    void Start() {
        DontDestroyOnLoad(this.gameObject);

        if (GameObject.FindGameObjectsWithTag("MaxWo").Length > 1) {
            Destroy(this.gameObject);
        }
    }
}
