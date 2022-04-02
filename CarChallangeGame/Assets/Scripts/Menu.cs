using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject buttons;
    public GameObject settings;
    public bool isSettingsOpen;

    public void openSettings()
    {
        if(isSettingsOpen == true)
        {
            isSettingsOpen = false;
            buttons.SetActive(true);
            settings.SetActive(false);
        }
        else
        {
            isSettingsOpen = true;
            buttons.SetActive(false);
            settings.SetActive(true);
        }
    }


    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
