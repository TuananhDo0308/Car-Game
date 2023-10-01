using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrMainMenu : MonoBehaviour
{
    public void StartGame(int level)
    {
        Time.timeScale = 1;
	SceneManager.LoadScene(level);
    }

    public void ReturnMenu()
    {
	SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
	Application.Quit();
    }
}
