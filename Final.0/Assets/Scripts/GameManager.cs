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
    // public Img o2Bar;
    private HealthBar o2Bar;
    public float waitTime = 0.5f;
    // public Animator rockAnimator;

    private void Awake()
    {
        titleScreen.gameObject.SetActive(true);
        globalData.gameStarted = false;
        globalData.ResetCashAmount();//remove
    }

    IEnumerator O2CountDown()
    {
        while (globalData.o2Percent > 0 && !globalData.isGameOver)
        {
            yield return new WaitForSeconds(waitTime);
            globalData.UpdateO2(-0.01f);
            // o2BarScript.DisplayValue();
            print(globalData.o2Percent);
        }
        if (globalData.o2Percent < 0) GameOver();
    }
    public void StartGame(/*int level*/)
    {
        globalData.isGameOver = false;
        globalData.gameStarted = true;
        // globalData.playerMovement = true;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        playerController.playerAudio.Play();
        // rockAnimator.gameObject.GetComponent<Animator>();
        // rockAnimator.Play();
        globalData.rockScore = 0;
        globalData.o2Percent = 1;
        UpdateScore(0);
        inGameScreen.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
        // o2Bar.StartCoroutine(o2Bar.O2CountDown());
        StartCoroutine(O2CountDown());
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
        // o2Bar.StopCoroutine(o2Bar.O2CountDown());
        StopCoroutine(O2CountDown());
    }

    public void GameWon()
    {
        globalData.isGameOver = true;
        StopCoroutine(O2CountDown());
        // o2Bar.StopCoroutine(o2Bar.O2CountDown());
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
        print("how do i skip the title screen upon restart...? hmmmm..."); //probably need scene loader
    }
    
   
}
