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
    public float speed = 5f;
    //variable is "speed"
    public int score = 100; 
    // int must be a whole interger
    public float Health = 50.0f;
    public string Password;
    public int Points;
    public string playerName;

    

    // Update is called once per frame
    //private means it cannot be seen from the Unity editor, as if you had your blinds closed
    private void Update()
    {
        // var declares variables inside a function
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(hInput, vInput, 0);
        // the "." accesses the modifiers inside the class (transform or Time in this case)
  
    }

    public void Up()
    {
        Debug.Log(message: "what did you think this was going to do?");
    }
    
    public void Down()
    {
        
        Debug.Log(message: "what did you think this was going to do?");
    }
}
