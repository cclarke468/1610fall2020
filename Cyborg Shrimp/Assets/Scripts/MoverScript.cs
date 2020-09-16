using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public UnityEngine.UI.Text textbox;
    public void PrintText(string messageToPrint)
    {
        
    }

    public Vector3 coordinates; 
    void Start()
    {
        Debug.Log(message: "Hello!");
    }
    public float speed = 1f;
    public int score = 100;
    public float health = 50.0f;
    public string password;
    public int points;
    public string playerName = "Buddy the Cube";
    
    private void Update()
    {
        // var declares variables inside a function
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(hInput, vInput, 0);
        //fix "jump" if else statement below
        if (Input.GetButton("Jump") && coordinates.z == 0)
        {
            coordinates.z = 45;
            transform.Rotate(coordinates);
            print("Jump");
        }
        else
        {
            coordinates.z = 0;
            transform.Rotate(coordinates);
            print("No jump");
        }

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
