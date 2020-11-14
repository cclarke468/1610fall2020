using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class GlobalData : ScriptableObject
{
    public bool isGameOver;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public List<GameObject> rockList;
    public TextMeshProUGUI scoreText;
    private int rockScore;
    public void StartGame(/*int level*/)
    {
        isGameOver = false;
        // StartCoroutine(SpawnTarget());
        rockScore = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }
    public void UpdateScore(int scoreToAdd)
    {
        rockScore += scoreToAdd;
        scoreText.text = rockScore + " Rocks";
    }
    public void GameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
        isGameOver = true;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
