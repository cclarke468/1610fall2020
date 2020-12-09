using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float jumpForce = 30f;
    private float gravityModifier = 0.5f;
    public GlobalData globalData; 
    public GameManager gameManager;
    public Animator playerAnimator; 
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioSource playerAudio;
    private bool isOnGround = true;
    // public MoveHorizontal moveHorizontal;
    public float speed = 10f; 
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier; //add jump physics created in class
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }
    void Update()
    {
        PlayerMovement();
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !globalData.isGameOver) //if player jumps off ground
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
    private void OnCollisionEnter(Collision collidedObject) //on collision slows game...?
    {
        if (collidedObject.gameObject.CompareTag("Ground")) //use tags in Unity to refer to specific game objects
        {
            isOnGround = true; //should I use a CharacterController.isGrounded instead??
            dirtParticle.Play();
        }
        else if (collidedObject.gameObject.CompareTag("InstaDeath")) //change tag
        {
            //PROBLEM: only works when gameObject is no longer "trigger"
            PlayerDeath();
            gameManager.GameOver();
        }
        else if (collidedObject.gameObject.CompareTag("Debug"))
        {
            print("DEBUG OBJECT");
        }
    }

    public void PlayerMovement()
    {
        if (globalData.gameStarted && !globalData.isGameOver)
        {
            var hInput = Input.GetAxis("Horizontal"); 
            if (!globalData.isGameOver)
            {
                transform.Translate(Time.deltaTime * speed * new Vector3(hInput,0,0), Space.World);
            }
        }
    }
    
    public void PlayerDeath()
    {
        globalData.isGameOver = true;
        globalData.gameStarted = false;
        playerAnimator.SetBool("Death_b", true);
        playerAnimator.SetInteger("DeathType_int",1);
        explosionParticle.Play();
        dirtParticle.Stop(); 
        playerAudio.Stop();
        playerAudio.PlayOneShot(crashSound, 1.0f);
        gameManager.GameOver();
    }
}
