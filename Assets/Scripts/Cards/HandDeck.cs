using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDeck : MonoBehaviour
{
    private Canvas deckCanvas;
    private const int deckMaxSize = 10;
    [SerializeField]
    //angulo em graus da primeira carta
    private const float fstCardAngle = 20f;
    public float cardOffset = 1f;

    public List<Card> deck;


    void Start()
    {
        deckCanvas = GetComponent<Canvas>();
    }

    void Update()
    {
        PlaceCards();
    }

    private void PlaceCards()
    {
        float curretAngle = -fstCardAngle;
        float offsetAngle = (fstCardAngle * 2) / (deck.Count - 1);

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 axisPoint = new Vector2(transform.position.x, transform.position.y - cardOffset * deck.Count);

        for (int i = 0; i < deck.Count; i++)
        {
            Card c = deck[i];
            Bounds cBounds = c.GetComponent<BoxCollider2D>().bounds;

            c.transform.position = transform.position;
            c.transform.rotation = transform.rotation;
            c.transform.localScale = Vector2.one;
            c.transform.RotateAround(axisPoint, Vector3.forward, curretAngle);

            curretAngle += offsetAngle;
        }

        for (int i = 0; i < deck.Count; i++)
        {
            Card c = deck[i];
            Bounds cBounds = c.GetComponent<BoxCollider2D>().bounds;

            if (cBounds.Contains(mousePos))
            {
                c.transform.rotation = transform.rotation;
                c.transform.localScale = new Vector2(2, 2);
                c.transform.position = new Vector2(c.transform.position.x, transform.position.y);
                break;
            }
        }
    }
}
