using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    Animator myAnim;
    public bool atack;
    // Start is called before the first frame update
    void Start()
    {
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
    }
}
