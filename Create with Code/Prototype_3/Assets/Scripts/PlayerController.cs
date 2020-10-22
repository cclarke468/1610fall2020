using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float jumpForce = 45f;
    private float gravityModifier = 2.5f;
    public bool gameOver;
    private GlobalData gameOverGlobal; //NEW global data script with bool
    private Animator playerAnimator; 
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    void Start()
    {
        //in order to access components of Rigidbody (like "transform._____") we have to use code
        playerRigidbody = GetComponent<Rigidbody>();
        //now we can access stuff inside Rigidbody, like "AddForce"
        
        Physics.gravity *= gravityModifier;
        //this statement accesses the game's physics...now we can mess with Unity's gravity
        
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    private bool isOnGround = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) //if player jumps off ground
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
            //ForceMode has 4 types of forces; impulse applies the wanted force immediately instead of over time, which is the default
            
            isOnGround = false;
            playerAnimator.SetTrigger("Jump_trig");
                //PROBLEM: can't edit running jump state in unity editor
                
            dirtParticle.Stop(); 
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }
    //to tell when player collides with the ground, or another object...
    private void OnCollisionEnter(Collision collidedObject)
    {
        if (collidedObject.gameObject.CompareTag("Ground")) //use tags in Unity to refer to specific game objects
        {
            isOnGround = true;
            dirtParticle.Play(); 
        }
        else if (collidedObject.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            gameOverGlobal.gameOverBool = true;
            Debug.Log("Game Over!");
            // if (!gameOverGlobal.gameOverBool)
            // {
            //     Debug.Log("Global data game over is true");
            // }
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int",1);
            explosionParticle.Play();
            dirtParticle.Stop(); 
            playerAudio.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
