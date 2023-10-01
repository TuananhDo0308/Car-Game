using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarManager : MonoBehaviour
{
    public static bool isGameOver,isGameWin;
    public GameObject gameOverScreen,gameWinScreen,gamePauseScreen,btnPause,time;
    private void Awake(){
        isGameOver = false;
        isGameWin=false;
    }
    // Start is called before the first frame update
    void Start(){

    }
    void Update()
    {
        if(isGameOver){
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
            gameObject.SetActive(false);
            btnPause.SetActive(false);
            time.SetActive(false);
        } 
        if(isGameWin){
            Time.timeScale = 0;
            time.SetActive(false);
            gameObject.SetActive(false);
            gameWinScreen.SetActive(true);
            btnPause.SetActive(false);
        }
    }
    public void PauseGame(){
        Time.timeScale = 0;
        gamePauseScreen.SetActive(true);
        btnPause.SetActive(false);
    }
    public void ContinueGame(){
        Time.timeScale = 1.0f;
        gamePauseScreen.SetActive(false);
        btnPause.SetActive(true);
    }
    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale=1.0f;
    }
    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
    public void ReplayLevel(){
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
