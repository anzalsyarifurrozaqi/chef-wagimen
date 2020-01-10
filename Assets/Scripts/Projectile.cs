using UnityEngine;

public class Projectile : MonoBehaviour
{
    private static float damage = 5;
    public float speed;
    PlayerHP playerHP;
    private Transform player;
    private Vector2 target;
    
    // Start is called before the first frame update
    void Start()
    {
        playerHP = GameObject.Find("HealthBar").GetComponent<PlayerHP>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y){
           DestroyProjectile();
        }
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            playerHP.GetComponent<PlayerHP>().takeDamage(damage);
            DestroyProjectile();
        }       
    }
    void DestroyProjectile(){       
        Destroy(gameObject);
    }

}
