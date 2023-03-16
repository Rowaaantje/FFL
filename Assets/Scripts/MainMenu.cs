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

    public void PlayStappenteller ()
    {
        SceneManager.LoadScene("Stappenteller");
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
}
