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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f),
                        new Vector2(transform.position.x + 0.5f, transform.position.y - 0.51f), groundLayers);
       
        //Debug.Log(isGrounded);
        if (moveright)
        {
            /*transform.localScale = new Vector3(1, 1, 1);*/
            rb.velocity = new Vector3(moveSpeed, rb.velocity.y, 0f);
            // myAnim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        }
        if (moveleft)
        {
            /*transform.localScale = new Vector3(-1, 1, 1);*/
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, 0f);
            // myAnim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        }
        if (moveJump && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, 0f);
            // jumpSound.Play();
        }
    }
}
