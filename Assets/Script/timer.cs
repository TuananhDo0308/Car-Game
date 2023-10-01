using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText, topTimer, yourTimer;
    float elapsedTime;
    public int seconds,minutes;
    static int[] TopMinutes=new int [6],TopSeconds= new int [6];
    // Update is called once per frame
    static int[] countLap1= new int [6];
    void Update()
    {
        if(CarManager.isGameWin){
            yourTimer.text = string.Format("{0:00}:{1:00}",minutes,seconds); 
            topTimer.text = getHighscore();
            countLap1[SceneManager.GetActiveScene().buildIndex-1]++;
        }
        elapsedTime += Time.deltaTime;
        minutes = Mathf.FloorToInt(elapsedTime / 60);
        seconds = Mathf.FloorToInt(elapsedTime % 60);
        //timerText.text = elapsedTime.ToString();
        timerText.text = string.Format("{0:00}:{1:00}",minutes,seconds); 
    }
    private string getHighscore(){
        int level=SceneManager.GetActiveScene().buildIndex-1;
            if(countLap1[level]==0) 
            {
                TopMinutes[level]=minutes;
                TopSeconds[level]=seconds;
            }
            if(TopMinutes[level]>minutes){
                TopMinutes[level]=minutes;
                TopSeconds[level]=seconds;
            }
            else if(TopSeconds[level]>seconds){
                TopMinutes[level]=minutes;
                TopSeconds[level]=seconds;
            }
            return string.Format("{0:00}:{1:00}",TopMinutes[level],TopSeconds[level]); 
    }
}
