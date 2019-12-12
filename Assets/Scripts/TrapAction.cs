using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapAction : MonoBehaviour
{
    public float damage;
    public GameObject playerHP;
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("benturan");
            playerHP.GetComponent<PlayerHP>().takeDamage(damage);
            die();
        }
    }
    // void OnTriggerEnter2D (Collider2D other)
    // {
    //     if (other.gameObject.CompareTag("Player")) {
    //         playerHP.GetComponent<PlayerHP>().takeDamage(damage);
    //         die();
    //     }
    // }

    void die()
    {
        Destroy(this.gameObject);
    }
}
