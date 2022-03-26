using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play ()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Quit ()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
