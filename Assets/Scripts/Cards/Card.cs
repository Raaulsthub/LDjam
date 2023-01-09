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
    private Canvas deckCanvas;


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
        CardManager manager = CardManager.GetIsntace();
        manager.PutCardOnTable(e);
    }

    

}
