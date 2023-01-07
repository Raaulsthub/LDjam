using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCardAtt : Card
{
    [SerializeField] private int damage;
    [SerializeField] private int life;
    [SerializeField] private int moneyGen;
    private PlayerInfo player;

    public void Start()
    {
        // catar o player
    }
    public void DealDemage(int damage)
    {
        life -= damage;
    }

    public void GenerateMoney()
    {
        player.DepositMoney(moneyGen);
    }
}
