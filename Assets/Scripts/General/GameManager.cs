using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerInfo player;
    [SerializeField] ComputerInfo bot;
    [SerializeField] CardManager cardManager;

    //obs: por enquanto só tem milho pq os prefabs das outras cartas n tão prontos
    //all playable cards in game(without repeting) 
    [SerializeField] GameObject allCards;


    private int round; // used for money calculum, damage, etc
    public bool PlayerPlayed { get; private set; }
    public bool ComputerPlayed { get; private set; }
    private bool whosFirst; // player == false, computer == true
    private bool playerAllowed; // player is allowed to play
    private bool computerAllowed;

    //singleton
    private static GameManager instance;
    public static GameManager GetInstance()
    {
        return instance;
    }

    void Start()
    {
        this.round = 0;
        this.ComputerPlayed = false;
        this.PlayerPlayed = false;
        this.whosFirst = false; // will only update when round update is first called
        this.playerAllowed = true;
        this.computerAllowed = false;
        instance = this;
    }



    void Update()
    {
        if (player.isAlive == false)
        {
            return; // should load game over screen
        }
        if (bot.isAlive == false)
        {
            return; // should load you won screen
        }

        // main game loop

        if (!this.PlayerPlayed)
        {
            computerAllowed = true;
            return;
        }

        if(computerAllowed)
        {
            StartCoroutine(bot.SimulatePlay());
            computerAllowed = false;
        }
        
        if (!this.ComputerPlayed)
        {
            return;
        }

        if (PlayerPlayed && ComputerPlayed)
        {
            Debug.Log("ROUND UPDATE");
            RoundUpdate();
        }
    }

    void RoundUpdate()
    { 
        //random card from all possibles ones
        addCard(bot.handDeck);
        addCard(player.handDeck);

    // money update - standart round money earn + looping the monster plants on board to deposit their earnings
    // life update - damage to the plants and user

        PlayerPlayed = false;
        ComputerPlayed = false;

        computerAllowed = true;
        playerAllowed = true;
        
        // MAKE SURE WHEN PLAYER/COMPUTER PLAYS THESE VARIABLES GO FALSE

        this.round++;
    }

    public void PlayerSetPlayed()
    {
        PlayerPlayed = true;
    }

    public void BotSetPlayed()
    {
        ComputerPlayed = true;
    }

    private void addCard(HandDeck deck)
    {
        int count = allCards.transform.childCount;
        int index = Random.Range(0, count - 1);

        if(allCards.transform.childCount == 0)
        {
            return;
            Debug.Log("sem novas cartas para comprar");
        }

        Transform t = allCards.transform.GetChild(index);
        t.SetParent(deck.transform);
        deck.deck.Add(t.GetComponent<Card>());
    }
}