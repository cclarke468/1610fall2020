using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{
    public float speed = 10f;
    private float bottomBound = -5f;
    public GlobalData globalData; //NEW global data script with bool
    void Start()
    {
 
    }

    void Update()
    {
        var hInput = -Input.GetAxis("Horizontal"); //negative because backdrop needs to move opposite the player
        if (!globalData.isGameOver)
        {
            transform.Translate(Time.deltaTime * speed * new Vector3(hInput,0,0), Space.World);
        }

        if (transform.position.y < bottomBound && gameObject.CompareTag("Rock"))
        {
            Destroy(gameObject); //destroy obstacles passing left boundary
        }
    }
}
