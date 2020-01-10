using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisau : MonoBehaviour
{       
    public float speed;
    int indexOfEnemy;    
    private Vector2 target;
    GameObject[] Enemys;
    
    // Start is called before the first frame update
    void Start()
    {
                 
    }

    // Update is called once per frame
    void FixedUpdate()
    {        
        Enemys = PlayerController.instantiate.Enemys;
        Debug.Log(Enemys.Length);
        indexOfEnemy = EnemyGenerator.instantiate.i;

        if (Enemys[indexOfEnemy] != null)
        {
            target = new Vector2(Enemys[indexOfEnemy].transform.position.x, Enemys[indexOfEnemy].transform.position.y);
       
            Debug.Log(indexOfEnemy);
            // Debug.Log(target);        
                    
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        
        
        if (transform.position.x == target.x)
        {
            DestroyPisau();
        }
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("pisau");
            buttonPisauLempar();
            // Destroy(gameObject);
        }  
        
        if(other.CompareTag("Enemy")){            
            Destroy(other.gameObject);
        }  
    }
    void DestroyPisau(){       
        Destroy(gameObject);
    }
   
    public void buttonPisauLempar()
    {
        GameObject gameOverParent = GameObject.Find("Canvas");
        GameObject buttonAttackLempar = gameOverParent.transform.Find("atack lempar").gameObject;

        buttonAttackLempar.SetActive(true);
    }
}
