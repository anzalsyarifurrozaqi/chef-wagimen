using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float maxHealth;
    float health;
    Image healthBar;
   void Start()
   {
       health = maxHealth;
        healthBar = GetComponent<Image>();
   }
    void Update()
    {
        Debug.Log(health);
        healthBar.fillAmount = health / maxHealth;
    }

    public void takeDamage (float damage) {
        health -= damage;  
    }
}
