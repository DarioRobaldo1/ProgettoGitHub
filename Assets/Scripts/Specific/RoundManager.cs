using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundManager : MonoBehaviour
{
    [SerializeField] private int RemainingTime = 120;
    [SerializeField] private int StartingCountdown = 3;
    public bool HasGameStarted => StartingCountdown <= 0;
    [SerializeField] private string NextScene = "";
    [SerializeField] private string GameOverScene = "";
    [SerializeField] private TextMeshProUGUI TimerText;
    [SerializeField] private TextMeshProUGUI CountdownText;
    [SerializeField] private float timer1s = 1.0f;
    private int remainingWeeds = 0;
    private void Start()
    {
        CountdownText.enabled = true;
        TimerText.enabled = false;
    }
    private void Update()
    {
        timer1s -= Time.deltaTime;
        if (timer1s <= .0f)
        {
            timer1s = 1.0f;
            if (StartingCountdown > 0)
            {
                --StartingCountdown;
                CountdownText.text = $"{StartingCountdown}";
                if (StartingCountdown <= 0)
                {
                    CountdownText.enabled = false;
                    TimerText.enabled = true;
                    TimerText.text = string.Format("{0:00}:{1:00}", RemainingTime / 60, RemainingTime % 60);
                }
            }
            else
            {
                --RemainingTime;
                TimerText.text = string.Format("{0:00}:{1:00}", RemainingTime / 60, RemainingTime % 60);
                if (RemainingTime <= 0)
                {
                    SceneManager.LoadScene(GameOverScene);
                }
            }
        }
    }
    public void OnWeedDestroyed()
    {
        --remainingWeeds;
        if (remainingWeeds <= 0)
        {
            SceneManager.LoadScene(NextScene);
        }
    }
    public void OnWeedSpawned()
    {
        ++remainingWeeds;
    }
}
