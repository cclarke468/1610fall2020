using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10f;
    private float bottomBound = -5f;
    public GlobalData gameOver; //NEW global data script with bool
    void Start()
    {
 
    }

    void Update()
    {
        var hInput = -Input.GetAxis("Horizontal"); //negative because backdrop needs to move opposite the player
        if (!gameOver.gameOverBool)
        {
            transform.Translate(Time.deltaTime * speed * new Vector3(hInput,0,0));
        }

        if (transform.position.y < bottomBound && gameObject.CompareTag("Rock"))
        {
            Destroy(gameObject); //destroy obstacles passing left boundary
        }
    }
}
