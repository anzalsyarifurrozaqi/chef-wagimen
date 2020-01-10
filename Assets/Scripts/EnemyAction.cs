using UnityEngine;

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
        EnemyGenerator.instantiate.die = true;
        Destroy(this.gameObject);
    }
}
