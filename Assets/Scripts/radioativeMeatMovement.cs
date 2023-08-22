using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioativeMeatMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public Transform ceillingCheck;
    public Transform groundCheck;
    public LayerMask groundObjects;
    public float checkRadius;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;
    private bool isJumping = false;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //GetInputs
        ProcessInputs();

        //Animate
        Animate();

       
    }

    //Better for handling Physics, can be called multiple times per update frame.
    private void FixedUpdate()
    {
        

        //move
        Move();
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
        isJumping = false;
    }

    private void Animate()
    {
        if (moveDirection > 0 && !facingRight)
        {
            FlipCharacter();
        }
        else if (moveDirection < 0 && facingRight)
        {
            FlipCharacter();
        }
    }
    //oi

    private void ProcessInputs()
    {
        moveDirection = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }

        //check if is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObjects);
    }

    private void FlipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
