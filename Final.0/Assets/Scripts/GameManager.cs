﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // public List<GameObject> rockList;
    public TextMeshProUGUI scoreText;
    public GlobalData globalData;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public PlayerController playerController;

    private void Awake()
    {
        titleScreen.gameObject.SetActive(true);
        globalData.gameStarted = false;
        globalData.ResetCashAmount();//remove
    }

    public void StartGame(/*int level*/)
    {
        globalData.isGameOver = false;
        globalData.gameStarted = true;
        // globalData.playerMovement = true;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        playerController.playerAudio.Play();
        globalData.rockScore = 0;
        globalData.o2Percent = 1;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }

    public void UpdateScore(int scoreToAdd)
    {
        globalData.rockScore += scoreToAdd;
        scoreText.text = globalData.rockScore + " Rocks";
    }
    public void GameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
        globalData.isGameOver = true;
    }

    public void GameWon()
    {
        globalData.CalculateCashEarned();
        print("You got "+globalData.rockScore+" rock(s) and had "+globalData.o2Percent+"% o2 left! " +
              "You get $"+globalData.cash+"!");
        globalData.isGameOver = true;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        print("how do i skip the title screen upon restart...? hmmmm...");
    }
    
}
