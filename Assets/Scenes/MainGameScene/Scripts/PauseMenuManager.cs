using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject wristUI;
    public bool activeWristUI = true;


    void Start()
    {
        DisplayWristUI();
    }


    


    public void Reload()
    {
        SceneManager.LoadScene(0);

    }



    public void DisplayWristUI()
    {
        if (activeWristUI)
        {
            wristUI.SetActive(false);
            activeWristUI = false;
            Time.timeScale = 1;
        }
        else if (!activeWristUI)
        {
            wristUI.SetActive(true);
            activeWristUI = true;
            Time.timeScale = 0;
        }
    }

    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
            DisplayWristUI();
    }

    public void RestartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
