﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemicu : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            animator.SetBool("isJatuh", true);
        }        
    }
}
