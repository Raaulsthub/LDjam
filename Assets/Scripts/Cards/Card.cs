using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Card : MonoBehaviour
{

    [SerializeField]
    private int cost;

    public UnityAction<Card> OnSpawnEvent;
    public UnityAction<Card> OnDestroyEvent;
    public UnityAction<Card> OnUpdateEvent;
    public UnityAction<Card> OnHitTakenEvent;

    const int deckSize = 10;
    private HandDeck handDeck = null;
    private PlayerInfo player = null;
    private float selectedZoom = 1.5f;
    private float unSelectedZoom = 0.8f;


    // Start is called before the first frame update
    void Start()
    {
        OnSpawnEvent += Spawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Spawn(Card e)
    {
        CardManager card = CardManager.GetIsntace();
        GameManager game = GameManager.GetInstance();
        card.PutAllyCardOnTable(e);
        
        if(!game.PlayerPlayed && !game.ComputerPlayed)
        {
            this.handDeck = card.allyHandDeck;
            this.player = card.player;
        }
        else
        {
            this.handDeck = card.enemyHandDeck;
            this.player = card.bot;
        }
    }

    public List<Card> GetAllies()
    {
        return handDeck.deck;
    }

    public PlayerInfo GetPlayer()
    {
        return player;
    }

    public void SetSelectedScale()
    {
        float s = transform.localScale.x * selectedZoom;
        transform.localScale = new Vector2(s,s);
    }

    public void SetDiselectedScale()
    {
        float s = transform.localScale.x / selectedZoom;
        transform.localScale = new Vector2(s,s);

        transform.rotation = Quaternion.identity;
    }

}
