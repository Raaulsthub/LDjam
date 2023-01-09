using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public void HealRandomAlly(CardEventArgs e)
    {
        List<Card> deck = e.card.GetAllies();

        int index = deck.Count;
        index = Random.Range(0, index);

        Card target = deck[index];
        target.life += 2;
    }

    public void IncreaseDamage(CardEventArgs e)
    {
        if(e.card.damage + 1 <= 4)
        {
            e.card.damage += 1;
        }
    }

    public void IncreaseCashBy2(CardEventArgs e)
    {
        PlayerInfo p = e.card.GetPlayer();
        p.DepositMoney(2);
    }

    public void IncreaseCashBy1(CardEventArgs e)
    {
        PlayerInfo p = e.card.GetPlayer();
        p.DepositMoney(1);
    }

    //pulgao power
    public void Respawn(CardEventArgs e)
    {

    }

    public void AtackLine(CardEventArgs e)
    {
        PlayerInfo p = e.card.GetPlayer();
        float yDir = e.card.transform.position.y - p.transform.position.y;

        BoxCollider2D collider = e.card.GetComponent<BoxCollider2D>();
        RaycastHit2D[] hits = new RaycastHit2D[4];
        collider.Raycast(new Vector2(0, yDir), hits);

        foreach(RaycastHit2D hit in hits)
        {
            Card card = hit.collider.transform.GetComponent<Card>();
            Debug.Log($"bati na carta {card.transform}");
        }

    }

}
