using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> rockList;
    public TextMeshProUGUI scoreText;
    public GlobalData globalData;
    public GameObject titleScreen;
    public GameObject gameOverScreen;

    // IEnumerator SpawnTarget()
    // {
    //     while (!gameIsOver)
    //     {
    //         yield return new WaitForSeconds(spawnRate);
    //         int index = Random.Range(0, rockList.Count); 
    //         Instantiate(rockList[index]);
    //     }
    // }
  
    public void StartGame(/*int level*/)
    {
        globalData.isGameOver = false;
        globalData.gameStarted = true;
        globalData.rockScore = 0;
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
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
