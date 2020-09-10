using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextEditor = UnityEditor.UI.TextEditor;

public class MoverScript : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.UI.Text textbox;
    public void PrintText(string messageToPrint)
    {
        
    }
    void Start()
    {
        Debug.Log(message: "Hello World!");
    }
    public float speed = 1f;
    public int score = 100;
    public float Health = 50.0f;
    public string Password;
    public int Points;
    public string playerName = "Buddy the Cube";

    

    // Update is called once per frame
    //private means it cannot be seen from the Unity editor
    private void Update()
    {
        // var declares variables inside a function
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(hInput, vInput, 0);

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

    
}
