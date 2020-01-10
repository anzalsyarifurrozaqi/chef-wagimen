using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public static PlayerAction instantiate;
    Animator myAnim;
    public bool atack;
    public bool atackLempar;
    public bool dead;    
    // Start is called before the first frame update
    void Start()
    {
        if (instantiate == null)
        {
            instantiate = this;
        }
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (atack)
        {
            myAnim.SetBool("isAtack", true);
        } else
        {
            myAnim.SetBool("isAtack", false);
        }

        if (atackLempar)
        {
            myAnim.SetBool("isAtackLempar", true);
        } else
        {
            myAnim.SetBool("isAtackLempar", false);
        }

        Debug.Log(dead);
        if (dead)
        {            
            myAnim.SetBool("isDead", true);
        }        
    }
}
