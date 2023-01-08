using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public PlayerInfo player;
    [SerializeField] public List<Card> allyCards = new List<Card>();
    [SerializeField] public List<Card> enemyCards = new List<Card>();
    [SerializeField] GameObject allyField;
    [SerializeField] GameObject enemyField;


    void Start(){
        Display();
    }

    private void Update(){
        foreach(Card card in player.handDeck.deck){
            foreach(Transform child in allyField.transform){
                Vector3 slotPos = child.position;
                Vector3 cardPos = Camera.main.WorldToScreenPoint(card.transform.position);

                Vector3 wh = new Vector3(child.GetComponent<RectTransform>().rect.width, child.GetComponent<RectTransform>().rect.height, 0);

                if((cardPos.x > slotPos.x-(wh.x/2) && cardPos.x < slotPos.x+(wh.x/2)) && (cardPos.y > slotPos.y-(wh.y/2) && cardPos.y < slotPos.y+(wh.y/2))){
                    Debug.Log(child.transform.GetSiblingIndex());
                    Transform cardS = allyField.transform.GetChild(child.transform.GetSiblingIndex());
                    CardSlot cs = cardS.GetComponent("CardSlot") as CardSlot;
                    cs.card = card;
                }
            }
        }
    }
    private void Display(){
        
    }
}