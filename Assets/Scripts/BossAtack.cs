using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAtack : MonoBehaviour
{
    public float startTimeBtwShots;
    private float timeBtwShots;   
    public Transform player;
    public bool attack;
    //Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;       
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timeBtwShots <= 0)
        {
            attack = true;            
            timeBtwShots = startTimeBtwShots;           
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
            attack = false;
        }
    }
}
