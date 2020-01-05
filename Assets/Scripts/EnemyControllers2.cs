using UnityEngine;

public class EnemyControllers2 : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;
    float objectDistance;
    public int indexEnemy;
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
        objectDistance = EnemyGenerator.instantiate.distance;

        //Debug.Log(objectDistance);
        setAction();   
    }
    void setAction()
    {
        
        
        if (objectDistance < 50 && EnemyGenerator.instantiate.i == indexEnemy)
        {
            GetComponent<EnemyMovement>().enabled = true;
            animator.SetBool("isWalking", true);
        } else
        {                
            GetComponent<EnemyMovement>().enabled = false;
            animator.SetBool("isWalking", false);
        }
       
                
    }
}   
