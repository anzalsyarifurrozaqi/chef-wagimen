using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    public float damage;
    public GameObject playerHP;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("benturan");
            playerHP.GetComponent<PlayerHP>().takeDamage(damage);
        }
    }
}
