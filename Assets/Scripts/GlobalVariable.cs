using UnityEngine;

public class GlobalVariable : MonoBehaviour
{
    PlayerHP playerHP;
    public float health;
    static float maxHealth = 100;
              
    void Awake()
    {
        DontDestroyOnLoad(this);
        playerHP = GameObject.Find("HealthBar").GetComponent<PlayerHP>();
        health = maxHealth;
    }
    void Start()
    {

    }
    void FixedUpdate()
    {
        health = playerHP.health;
        //Debug.Log(health);
    }
}
