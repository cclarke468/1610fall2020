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

    void Start()
    {
        isGameOver = false;
        gameStarted = false;
    }
}
