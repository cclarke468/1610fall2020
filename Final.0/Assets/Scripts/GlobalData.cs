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
    public float cash;
    void Start()
    {
        isGameOver = false;
        gameStarted = false;
        o2Percent = 1;
    }
    public float CalculateCashEarned()
    {
        o2Percent *= 100;
        cash += ((rockScore*300.14f) + (o2Percent / 3));
        return cash;
    }

    public void ResetCashAmount()
    {
        cash = 0;
    }
}
