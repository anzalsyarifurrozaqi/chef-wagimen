using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private PlayerAction playerAction;
    void Start()
    {
        Time.timeScale = 1;
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerAction = FindObjectOfType<PlayerAction>();
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
}
