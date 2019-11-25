using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;
    float objectDistance;
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
            GetComponent<EnemyMovement>().enabled = true;
        }
    }
}   
