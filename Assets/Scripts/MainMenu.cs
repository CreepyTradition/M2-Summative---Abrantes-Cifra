using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("KartSelect");
    }

    public void QuitGame()
    {
        Debug.Log("Player Has Quit.");
        Application.Quit();
    }
    public void Mainmenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}