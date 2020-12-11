using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
    public GameObject inGameScreen;
    private PlayerController playerController;
    public HealthBar o2Bar;

    private void Awake()
    {
        titleScreen.gameObject.SetActive(true);
        globalData.gameStarted = false;
        // globalData.ResetCashAmount();//remove
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
        inGameScreen.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
        while (globalData.o2Percent > 0)
        {
            globalData.UpdateO2(-0.01f);
            // o2Bar.DisplayValue();
            print(globalData.o2Percent);
        }
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
        print("You gathered "+globalData.rockScore+" rock(s) and had "+globalData.o2Percent+"% o2 left! " +
              "You now have $"+globalData.cash+" in cash!");
        globalData.isGameOver = true;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        print("how do i skip the title screen upon restart...? hmmmm..."); //probably need scene loader
    }
    
   
}
