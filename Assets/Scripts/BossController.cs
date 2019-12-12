using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    bool attack;
    Animator animator;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        attack = GetComponent<BossAtack>().attack;
        if (attack)
        {            
            animator.SetBool("isAttack", true);
            Instantiate(projectile, transform.position, Quaternion.identity);
        } else
        {
            animator.SetBool("isAttack", false);
        }
    }
}
