using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instantiate;
    private PlayerMovement playerMovement;
    private PlayerAction playerAction;
    public GameObject pisau;
    public GameObject player;
    public GameObject[] Enemys;
    void Start()
    {        
        Time.timeScale = 1;
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerAction = FindObjectOfType<PlayerAction>();
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");

        if (instantiate == null)
        {
            instantiate = this;
        }
    }

    public void LeftArrow() {
        playerMovement.moveleft = true;
        playerMovement.moveright = false;
    }
    public void RightArrow() {
        playerMovement.moveleft = false;
        playerMovement.moveright = true;
    }
    public void jumpButton() {
        playerMovement.moveJump = true;
    }
    public void releaseLeftArrow() {
        playerMovement.moveleft = false;
    }
    public void releaseRightArrow() {
        playerMovement.moveright = false;
    }
    public void releaseJumpButton() {
        playerMovement.moveJump = false;
    }
    public void atackButton()
    {
        playerAction.atack = true;
    }
    public void releaseAtackButton()
    {
        playerAction.atack = false;
    }

    public void atackLemparButton()
    {
        playerAction.atackLempar = true;
        if (EnemyGenerator.instantiate.distance < 15) 
        {
            Instantiate(pisau, player.transform.position, Quaternion.identity);
        }            
            
    }
    public void releaseAtackLemparButton()
    {
        playerAction.atackLempar = false;
    }
}
