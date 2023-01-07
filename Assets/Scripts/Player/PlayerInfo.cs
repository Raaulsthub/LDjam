using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private HealthBar health;
    [SerializeField] private int cash;
    public Canvas handDeckSpace;

    public bool isAlive { get; private set; } = true;

    [SerializeField]
    private List<Card> deck;
    private List<Card> handDeck;
    private Canvas deckCanvas;
    private const int deckSize = 10;
    private const float cardOffset = 1f;

    void Start()
    {
        health.setHP(100);
        health.inicia();

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            health.getDamage(10);
        }
        else if(Input.GetKeyDown(KeyCode.A)){
            health.heal(10);
        }

        if(health.getHP() <= 0)
        {
            isAlive = false;
        }
    }


    public void DepositMoney(int amount)
    {
        this.cash += amount;
    }
}
