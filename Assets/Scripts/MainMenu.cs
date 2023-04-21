using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayMenu()
    {
        SceneManager.LoadScene("Menu");

    }

    public void PlayWorkouts()
    {
        SceneManager.LoadScene("Workouts");
    }

    public void PlayStappenteller ()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayWorkoutProgramma ()
    {
        SceneManager.LoadScene("WorkoutPrograms");
    }
    public void PlayGyro ()
    {
        SceneManager.LoadScene("Gyro");
    }
    public void Play5minuteworkout()
    {
        SceneManager.LoadScene("5MinWorkout");
    }
    public void Play10minuteworkout()
    {
        SceneManager.LoadScene("10MinWorkout");
    }
    public void Play15minuteworkout()
    {
        SceneManager.LoadScene("15MinWorkout");
    }
    public void PlayUI_ebi()
    {
        SceneManager.LoadScene("UI_ebi");
    }
    public void Play1prisonersquats(int MaxWo)
    {
        GameObject.Find("MaxWOGO").GetComponent<MaxWo>().MaxNum = MaxWo;
        SceneManager.LoadScene("1prisonersquats");
    }

    public void Play2Lunges()
    {
        SceneManager.LoadScene("2Lunges");
    }

    public void Play3Crunches()
    {
        SceneManager.LoadScene("3Crunches");
    }

    public void Play4Legraises()
    {
        SceneManager.LoadScene("4Legraises");
    }

    public void Play5Planking()
    {
        SceneManager.LoadScene("5Planking");
    }
    public void Play6Pushups()
    {
        if(GameObject.Find("MaxWOGO").GetComponent<MaxWo>().MaxNum == 5) {
            SceneManager.LoadScene("Menu");
        } else {
            SceneManager.LoadScene("6Pushups");
        }
    }
    public void Play7Sideplankdips()
    {
        SceneManager.LoadScene("7Sideplankdips");
    }
    public void Play8Sideplankdips()
    {
        SceneManager.LoadScene("8Sideplankdips");
    }
    public void Play9Situps()
    {
        SceneManager.LoadScene("9Situps");
    }

    public void Play10Jumpingjacks()
    {
        SceneManager.LoadScene("10Jumpingjacks");
    }
    public void Play11Floordips()
    {
        if(GameObject.Find("MaxWOGO").GetComponent<MaxWo>().MaxNum == 10) {
            SceneManager.LoadScene("Menu");
        } else {
            SceneManager.LoadScene("11Floordips");
        }
    }
    public void Play12glutebridges()
    {
        SceneManager.LoadScene("12glutebridges");
    }
    public void Play13Goodmornings()
    {
        SceneManager.LoadScene("13Goodmornings");
    }
    public void Play14Toetouches()
    {
        SceneManager.LoadScene("14Toetouches");
    }
    public void Play15Tuckeddragonpresshold()
    {
        SceneManager.LoadScene("15Tuckeddragonpresshold");
    }
    public void PlayPrestaties()
    {
        SceneManager.LoadScene("Prestaties");
    }
}
