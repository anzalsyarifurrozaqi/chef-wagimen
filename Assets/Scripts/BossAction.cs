using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAction : MonoBehaviour
{
     public float damage;
    public GameObject enemyHP;
     void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Knife")) {
            enemyHP.GetComponent<EnemyHP>() .takeDamage(damage);
        }
    }
}
