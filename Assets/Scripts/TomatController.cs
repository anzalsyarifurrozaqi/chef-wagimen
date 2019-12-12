using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TomatController : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;
    float objectDistance;

    public int animCounter = 0;
	Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > player.transform.position.x)
            objectDistance = transform.position.x - player.transform.position.x;
        else
            objectDistance = player.transform.position.x - transform.position.x;

        //Debug.Log(objectDistance);
        setAction();   
    }
    void setAction()
    {
        if(objectDistance > 15)
        {
            GetComponent<EnemyMovement>().enabled = false;
        }else
        {
            animCounter = 1;
			animator.SetInteger("Counter",animCounter);
            GetComponent<EnemyMovement>().enabled = true;
        }
    }
}
