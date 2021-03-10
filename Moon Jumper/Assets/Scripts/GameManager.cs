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
    public TextMeshProUGUI o2PercentText;
    public GlobalData globalData;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public GameObject inGameScreen;
    public GameObject gameWonScreen;
    private PlayerController playerController;
    public HealthBar o2Bar;
    public float waitTime = 0.2f;
    
    private void Awake()
    {
        titleScreen.gameObject.SetActive(true);
        globalData.gameStarted = false;
        globalData.ResetCashAmount();
    }

    IEnumerator O2CountDown()
    {
        while (globalData.o2Percent > 0 && !globalData.isGameOver)
        {
            yield return new WaitForSeconds(waitTime);
            globalData.UpdateO2(-0.01f);
            o2Bar.DisplayValue();
            o2PercentText.text = Mathf.Floor(globalData.o2Percent * 100) + "%";
            if (globalData.o2Percent < 0) GameOver();
        }
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
        StartCoroutine(O2CountDown());
    }

    public void UpdateScore(int scoreToAdd)
    {
        globalData.rockScore += scoreToAdd;
        scoreText.text = globalData.rockScore + " Rocks";
    }
    public void GameOver()
    {
        //wait 3 seconds
        gameOverScreen.gameObject.SetActive(true);
        inGameScreen.gameObject.SetActive(false);
        globalData.isGameOver = true;
        StopCoroutine(O2CountDown());
    }

    public void GameWon()
    {
        globalData.isGameOver = true;
        inGameScreen.gameObject.SetActive(false);
        gameWonScreen.gameObject.SetActive(true);
        StopCoroutine(O2CountDown());
        if (globalData.rockScore > 0) //create text box that prints this
        {
            for (int i = 0; i < globalData.rockScore; i++)
            {
                int rockCount = i + 1;
                print("Calculating rocks collected: " + rockCount);
            }
        }
        print("You gathered "+globalData.rockScore+" rock(s) and had "+globalData.o2Percent*100+"% o2 left! " +
              "You now have $"+globalData.CalculateCashEarned()+" in cash!");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
   
}
