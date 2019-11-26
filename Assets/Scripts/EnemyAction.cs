﻿using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Knife")) {
            die();
        }
    }

    void die()
    {
        Destroy(this.gameObject);
        EnemyGenerator.instantiate.die = true;
    }
}
