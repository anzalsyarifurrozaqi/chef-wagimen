using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool moveJump, moveleft, moveright;
    public bool isGrounded;
    public float jumpSpeed;
    public float moveSpeed;
    Rigidbody2D rb;
    public LayerMask groundLayers;
    Animator animator;


    void awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Lumpur"))
        {
            moveSpeed = 2;
        }
        else{
            moveSpeed = 8;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f),
                        new Vector2(transform.position.x + 0.5f, transform.position.y - 2.79f), groundLayers);
       
        //Debug.Log(isGrounded);
        if (moveright)
        {
            transform.localScale = new Vector3(1, 1, 1);
            rb.velocity = new Vector3(moveSpeed, rb.velocity.y, 0f);
            animator.SetBool("isWalking", true);
        }
        

        if (moveleft)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, 0f);
            animator.SetBool("isWalking", true);
        }
        
        if (moveJump && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, 0f);
            animator.SetBool("transisi", true);
            
        }
        else if (moveJump && !isGrounded)
        {
            animator.SetBool("transisi", false);
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("transisi", false);
        }

        if (moveleft == false && moveright == false)
        {
            animator.SetBool("isWalking", false);        
        }        
    }
}
