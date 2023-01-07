using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    [SerializeField] PlayerInfo player;
    [SerializeField] ComputerInfo computer;
    private int round; // used for money calculum, damage, etc
    private bool playerPlayed;
    private bool computerPlayed;
    private bool whosFirst; // player == false, computer == true
    private bool playerAllowed; // player is allowed to play
    private bool computerAllowed;


    void Start()
    {
        this.round = 0;
        this.computerPlayed = false;
        this.playerPlayed = false;
        this.whosFirst = true; // will only update when round update is first called
        this.playerAllowed = true;
        this.computerAllowed = false;
    }

    void Update()
    {
        if (player.isAlive == false)
        {
            return; // should load game over screen
        }
        if (computer.isAlive == false)
        {
            return; // should load you won screen
        }

        // main game loop

        if (this.playerAllowed && !this.playerPlayed)
        {
            if (this.playerPlayed)
            {
                this.playerAllowed = false;
                this.computerAllowed = true;
                return;
            }
        }

        if(this.computerAllowed && !this.computerPlayed)
        {
            this.playerAllowed = true;
            this.computerAllowed = false;
            return;
        }

        if (playerPlayed && computerPlayed) RoundUpdate();
    }

    void RoundUpdate()
    {
        // money update - standart round money earn + looping the monster plants on board to deposit their earnings

        // life update - damage to the plants and user

        playerPlayed = false;
        playerPlayed = false;
        whosFirst = !whosFirst;

        if (whosFirst)
        {
            computerAllowed = true;
        } else
        {
            playerAllowed = true;
        }
        // MAKE SURE WHEN PLAYER/COMPUTER PLAYS THESE VARIABLES GO FALSE

        this.round++;
    }
}
