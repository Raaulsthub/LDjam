using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private HealtBar health = new HealtBar();
    [SerializeField] private int cash;

    private List<Card> deck;
    private List<Card> cards;

    void Start()
    {
        this.cash = 0;
    }



    void Update()
    {
        
    }

    public void TakeHit(int damage)
    {
        healt.getDamage(damage);
    }

    public void DepositMoney(int amount)
    {
        this.cash += amount;
    }
}
