using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    GlobalVariable globalVariable;
    public float health;
    static float maxHealth = 100;
    Image healthBar;

    void Start()
   {
        globalVariable = GameObject.Find("GlobalVariable").GetComponent<GlobalVariable>();        
        healthBar = GetComponent<Image>();
        health = globalVariable.health;
        //health = maxHealth;
   }
    void Update()
    {     
        healthBar.fillAmount = health / 100;
        GameOver();
    }

    public void takeDamage (float damage) {
        health -= damage;  
    }

    private void GameOver()
    {
        GameObject gameOverParent = GameObject.Find("Canvas");
        GameObject gameOver = gameOverParent.transform.Find("Game Over Panel").gameObject;
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
