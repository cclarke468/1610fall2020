﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> rockList;
    public TextMeshProUGUI scoreText;
    // public TextMeshProUGUI gameOverText;
    // public Button restartButton;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    private int score;
    private float spawnRate = 1f;
    public bool gameIsOver;
    

    IEnumerator SpawnTarget()
    {
        while (!gameIsOver)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, rockList.Count); 
            Instantiate(rockList[index]);
        }
    }
    public void StartGame(int difficulty)
    {
        gameIsOver = false;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        spawnRate /= difficulty;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score + " Rocks";
    }
    public void GameOver()
    {
        // gameOverText.gameObject.SetActive(true);
        // restartButton.gameObject.SetActive(true);
        gameOverScreen.gameObject.SetActive(true);
        gameIsOver = true;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
