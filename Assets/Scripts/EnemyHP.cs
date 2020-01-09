using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    //  GlobalVariable globalVariable;
    public float health;
    static float maxHealth = 100;
    Image healthBar;

    void Start()
   {
        // globalVariable = GameObject.Find("GlobalVariable").GetComponent<GlobalVariable>();        
        healthBar = GetComponent<Image>();
        health = maxHealth;
        //health = maxHealth;
   }
    void Update()
    {     
        healthBar.fillAmount = health / maxHealth;
        GameSucces();
    }

    public void takeDamage (float damage) {
        health -= damage;  
    }

    private void GameSucces()
    {
        GameObject gameOverParent = GameObject.Find("Canvas");
        GameObject gameOver = gameOverParent.transform.Find("Game Succes Panel").gameObject;
        if (health <= 0)
        {
            Destroy(GameObject.Find("GlobalVariable"));
            gameOver.SetActive(true);            
        } else
        {
            gameOver.SetActive(false);
        }
    }
}
