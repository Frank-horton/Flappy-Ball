using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text GameDurationText;
    public int CountGameDuration;
    public float time;
    private float timeStart;

    public GameObject GameOverPanel;

    private bool StopTime = true;
    public int endgamepanel;

    public Text GameAttemtsText;
    public int CountGameAttemts;

    private void Awake()
    {      
        if (!PlayerPrefs.HasKey("GameAttemts"))
        {
            PlayerPrefs.SetInt("GameAttemts", 0);
        }
    }

    private void Start()
    {       
        timeStart = time;
        CountGameAttemts = DataHolder.GameAttemptsCounter;      
        CountGameAttemts = PlayerPrefs.GetInt("GameAttemts");
    }

    private void Update()
    {
        SaveScorePlayer();
        Timer();

        if (endgamepanel == 1)EndGame();

        endgamepanel = Player.EndGamePanel;
    }

    void SaveScorePlayer()
    {
        GameDurationText.text = "Game Duration: " + CountGameDuration;
        GameAttemtsText.text = "Game Attemts: " + CountGameAttemts;
    }

    void Timer()
    {
        time -= Time.deltaTime;

        if (StopTime == true)
        {
            if (time <= 0)
            {
                CountGameDuration += 1;
                time = timeStart;
            }
        }
    }

    void EndGame()
    {
        GameOverPanel.SetActive(true);
    }
}