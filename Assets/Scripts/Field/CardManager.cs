using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public PlayerInfo player;
    [SerializeField] public HandDeck handDeck;
    [SerializeField] public List<Card> allyCards = new List<Card>();
    [SerializeField] public List<Card> enemyCards = new List<Card>();
    [SerializeField] GameObject allyField;
    [SerializeField] GameObject enemyField;

    //nunca instanciar mais de uma vez esta classe
    private static CardManager instance;

    public static CardManager GetIsntace()
    {
        return instance;
    }

    void Start() {
        Display();
        instance = this;
    }

    public void PutCardOnTable(Card card) {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        foreach (Transform child in allyField.transform)
        {
            Transform cardS = allyField.transform.GetChild(child.transform.GetSiblingIndex());
            CardSlot cs = cardS.GetComponent("CardSlot") as CardSlot;

            if (cs.isMouseOver)
            {
                cs.card = card;
                handDeck.deck.Remove(card);
            }
        }       
    }

    private void Display()
    {
        
    }
}