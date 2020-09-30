using UnityEngine;

public class MoverScript : MonoBehaviour
{
    private Vector3 playerDirection;
    private float yDirection;
    
    public CharacterController playerController;
    public float playerSpeed = 200f, gravity = -9.81f, jumpForce = 5f;

    private void Update()
    {
        // var declares a temp variable inside a function
        var hInput = playerSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        
        playerDirection.Set(hInput, yDirection, 0);
        
        //to make player fall faster the longer he's in the air (increase velocity)
        yDirection += gravity * Time.deltaTime;
       
        //to reset the falling speed after he hits the ground
        if (playerController.isGrounded && playerDirection.y < 0)
        {
            yDirection = -1f;
        }

        if (Input.GetButton("Jump"))
        {
            yDirection = jumpForce;
        }

        var movement = playerDirection * Time.deltaTime;
        playerController.Move(movement);

    }
    
    //to control the Up, Down, Left and Right buttons:
    public void Up()
    {
        print("what did you think this was going to do?");
        // transform.Translate(0,-playerSpeed,0);

    }
    public void Down()
    {
        print(message: "wrong way!");
        // transform.Translate(playerSpeed,0,0);
    }
    public void Right()
    {
        Debug.Log(message: "oops");
        // transform.Translate(-playerSpeed,0,0);
    }
    public void Left()
    {
        Debug.Log(message: "I think the directions are screwed up...");
        // transform.Translate(0,playerSpeed,0);
    }
    
}
