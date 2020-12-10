using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class GlobalData : ScriptableObject
{
    public bool isGameOver;
    public bool gameStarted;
    public int rockScore;
    // public bool playerMovement;
    public float o2Percent = 1;
    void Start()
    {
        isGameOver = false;
        gameStarted = false;
        o2Percent = 1;
    }
}
