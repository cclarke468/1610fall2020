using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{
    public float speed = 10f;
    private float bottomBound = -5f;
    private float topBound = 15f;
    public GlobalData globalData; //NEW global data script with bool
    void Start()
    {
 
    }

    // public void MoveOnInput(bool isOn)
    // {
    //     if (isOn)
    //     {
    //         var hInput = -Input.GetAxis("Horizontal"); //negative because backdrop needs to move opposite the player
    //         if (!globalData.isGameOver)
    //         {
    //             transform.Translate(Time.deltaTime * speed * new Vector3(hInput,0,0), Space.World);
    //         }
    //     }
    // }

    void Update()
    {
        // MoveOnInput(globalData.playerMovement);
        if (globalData.gameStarted && !globalData.isGameOver)
        {
            var hInput = -Input.GetAxis("Horizontal"); //negative because backdrop needs to move opposite the player
            if (!globalData.isGameOver)
            {
                transform.Translate(Time.deltaTime * speed * new Vector3(hInput,0,0), Space.World);
            }
        }
        if (transform.position.y < bottomBound && transform.position.y > topBound && gameObject.CompareTag("Rock"))
        {
            Destroy(gameObject); //destroy obstacles passing left boundary
        }
    }
}
