using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartPlay()
    {
        SceneManager.LoadScene("Main");
    }
    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

