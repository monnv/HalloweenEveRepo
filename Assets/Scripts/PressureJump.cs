using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureJump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Animator anim;


    private bool isGrounded;
    private bool facingRight = true;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("isGrounded", true);
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void Update()
    {

        #region jumping
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKey(KeyCode.Space) && isJumping == true)
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;

                anim.SetBool("isJumping", true);
                anim.SetBool("isGrounded", false);
            }
            else if (jumpTimeCounter < 0.1)
            {
                isJumping = false;

                anim.SetBool("isJumping", false);

            }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        if (isGrounded == true)
            {
                anim.SetBool("isJumping", false);
                anim.SetBool("isGrounded", true);
            }

        #endregion
        #region Running Animation

        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }

        else if (moveInput > 0)
        {
            anim.SetBool("isRunning", true);
        }
        else if (moveInput < 0)
        {
            anim.SetBool("isRunning", true);
        }
        #endregion
    }
}