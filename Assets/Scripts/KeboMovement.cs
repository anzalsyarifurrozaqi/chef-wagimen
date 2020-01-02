using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeboMovement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    // bool attack;
    //private float timeBtwShots;
    //public float startTimeBtwShots;
    
    //public GameObject projectile;
    Transform player;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        // attack = GetComponent<BossAtack>().attack;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // if (attack)
        // {
        //     animator.SetBool("isWalk", false);
        // }
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            animator.SetBool("isWalk", true);
        } else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
            animator.SetBool("isWalk", false);
        } else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
            animator.SetBool("isWalk", true);
        } else
        {
            animator.SetBool("isWalk", false);
        }
    }
}
