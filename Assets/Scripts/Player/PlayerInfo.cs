using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private int cash;

    private List<Card> deck;
    private List<Card> cards;

    void Start()
    {
        
    }



    void Update()
    {
        
    }

    public void TakeHit(int damage)
    {
        this.hp -= damage;
    }

    public void DepositMoney(int amount)
    {
        this.cash += amount;
    }
}