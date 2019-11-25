using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > player.transform.position.x)
        {
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, 0f);
        } else
        {
            rb.velocity = new Vector3(moveSpeed, rb.velocity.y, 0f);
        }
    }
}
