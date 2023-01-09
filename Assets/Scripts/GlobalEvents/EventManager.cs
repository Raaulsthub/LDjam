using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public void HealRandomAlly(Card e)
    {
        List<Card> deck = e.GetAllies();

        int index = deck.Count;
        index = Random.Range(0, index);

        Card target = deck[index];
        //target.life += 2
    }

    public void IncreaseAtack(Card e)
    {
        //e.atack += 1
    }

    public void IncreaseCashBy2(Card e)
    {
        PlayerInfo p = e.GetPlayer();
        //p.cash += 2;
    }

    public void IncreaseCashBy1(Card e)
    {
        PlayerInfo p = e.GetPlayer();
        //p.cash += 1;
    }

    public void AtackLine(Card e)
    {
        //BoxCollider2D collider = e.TryGetComponent<BoxCollider2D>();
    }

}
