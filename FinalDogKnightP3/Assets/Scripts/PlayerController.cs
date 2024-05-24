using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 3.5f;
    public float turnSpeed = 100.0f;
    public float jumpForce = 5;
    private Rigidbody playerRb;
   
    private float HorizontalInput;
    private float VerticalInput;
    private float ForwardInput;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");

        // Forward movement
        
        
            transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput); 
        

        // Rotates the player.

        transform.Rotate(Vector3.up, turnSpeed * HorizontalInput * Time.deltaTime);

        // Animation transitions.
        anim.SetFloat("Vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

           
        }
    }
}
