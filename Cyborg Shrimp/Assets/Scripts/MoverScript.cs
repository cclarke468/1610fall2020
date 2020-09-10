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
    public float speed = 1f;
    //variable is "speed"
    public int score = 100; 
    // int must be a whole interger
    public float Health = 50.0f;
    public string Password;
    public int Points;
    public string playerName = "Buddy the Cube";

    

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
        print("what did you think this was going to do?");
        transform.Translate(0,-speed,0);

    }
    
    public void Down()
    {
        print(message: "wrong way!");
        transform.Translate(speed,0,0);
    }
    
    public void Right()
    {
        Debug.Log(message: "oops");
        transform.Translate(-speed,0,0);
    }
    
    public void Left()
    {
        Debug.Log(message: "I think the directions are screwed up...");
        transform.Translate(0,speed,0);
    }

    public void PrintText()
    {
        
    }
}
