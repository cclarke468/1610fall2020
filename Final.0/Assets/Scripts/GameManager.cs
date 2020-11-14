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
    // public TextMeshProUGUI gameOverText;
    // public Button restartButton;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    private int rockScore;
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
  
    public void StartGame(/*int level*/)
    {
        gameIsOver = false;
        // StartCoroutine(SpawnTarget());
        rockScore = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        // spawnRate /= level;
    }

    public void UpdateScore(int scoreToAdd)
    {
        rockScore += scoreToAdd;
        scoreText.text = rockScore + " Rocks";
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
