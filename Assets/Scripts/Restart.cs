using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{   
    public void RestartLVL()
    {
        SceneManager.LoadScene(1);
        Player.EndGamePanel = 0;
        Time.timeScale = 1;
        DataHolder.GameAttemptsCounter += 1;
    }

    public void ChangeDifficulty()
    {
        SceneManager.LoadScene(0);
    }
}