using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    private static float damage = 10;
    public GameObject playerHP;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {          
            playerHP.GetComponent<PlayerHP>().takeDamage(damage);
        }
    }
}
