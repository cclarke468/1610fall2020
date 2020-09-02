using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1 * Time.deltaTime, 0, 0);
        
    }
}
