using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int NumbOfGameDifficulty;
 
    public void Play()
    {       
        SceneManager.LoadScene(1);
        Player.EndGamePanel = 0;
        Time.timeScale = 1;
        DataHolder.GameAttemptsCounter += 1;
        PlayerPrefs.SetInt("GameAttemts", DataHolder.GameAttemptsCounter);
    }

    public void Easy()
    {
        DataHolder.ChoisePlayer = 0;
        NumbOfGameDifficulty = DataHolder.ChoisePlayer;     
    }

    public void Medium()
    {
        DataHolder.ChoisePlayer = 1;
        NumbOfGameDifficulty = DataHolder.ChoisePlayer;     
    }

    public void Hard()
    {
        DataHolder.ChoisePlayer = 2;
        NumbOfGameDifficulty = DataHolder.ChoisePlayer;      
    }
}