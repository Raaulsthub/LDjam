using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using System;

public class Card : MonoBehaviour
{

    [SerializeField] private int cost;
    [SerializeField] private int damage;
    [SerializeField] private int life;
    [SerializeField] private int moneyGen;
    [SerializeField] private GameObject damageText;
    [SerializeField] private GameObject costText;
    [SerializeField] private GameObject lifeText;

    public UnityAction<Card> OnSpawnEvent;
    public UnityAction<Card> OnDestroyEvent;
    public UnityAction<Card> OnUpdateEvent;
    public UnityAction<Card> OnHitTakenEvent;

    const int deckSize = 10;
    private HandDeck handDeck = null;
    private float selectedZoom = 1.5f;
    private float unSelectedZoom = 0.8f;


    // Start is called before the first frame update
    void Start()
    {
        OnSpawnEvent += Spawn;
    }

    // Update is called once per frame
    void Update()
    {
        damageText.GetComponent<TextMeshPro>().text = damage.ToString();
        lifeText.GetComponent<TextMeshPro>().text = life.ToString();
        costText.GetComponent<TextMeshPro>().text = cost.ToString();
    }


    public void Spawn(Card e)
    {
        CardManager card = CardManager.GetIsntace();
        GameManager game = GameManager.GetInstance();
        card.PutAllyCardOnTable(e);
        
 

    }

    public void SetSelectedScale()
    {
        float s = transform.localScale.x * selectedZoom;
        transform.localScale = new Vector2(s,s);
    }

    public void SetDiselectedScale()
    {
        float s = transform.localScale.x / selectedZoom;
        transform.localScale = new Vector2(s,s);

        transform.rotation = Quaternion.identity;
    }

}
