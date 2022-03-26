using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseUI;

    public GameObject scoreMenu;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (isPaused)
            {
                Resume();
            }

            else
            {
                Paused();
            }    
            
        }
    }

    public void Resume ()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        scoreMenu.SetActive(true);
    }


    public void Paused ()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        scoreMenu.SetActive(false);

    }

    public void Menu ()
    {
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }


}
