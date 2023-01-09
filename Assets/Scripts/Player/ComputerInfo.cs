using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerInfo : PlayerInfo {

    private GameManager gameManager;
    private CardManager cardManager;

    public IEnumerator SimulatePlay()
    {
        yield return new WaitForSeconds(2);

        Debug.Log("Bot está a pensar. Hmmmmm.....");

        gameManager = GameManager.GetInstance();
        cardManager = CardManager.GetIsntace();

        int count = handDeck.deck.Count;
        int index = Random.Range(0, count - 1);
        int slot = Random.Range(0, 7);
        Card card = handDeck.deck[index];
        handDeck.deck.Remove(card);

        cardManager.PutEnemyCardOnTable(card, slot);
        gameManager.BotSetPlayed();
    }
}
