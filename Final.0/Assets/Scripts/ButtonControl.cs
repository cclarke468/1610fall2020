using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    private Button button;
    public GlobalData globalData;
    // public GameManager gameManager;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(GetLevel);
        // gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void GetLevel()
    {
        // gameManager.StartGame(/*level*/);
        globalData.StartGame(/*level*/);
    }

}
