using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour
{

    [SerializeField] public Card card;
    // Start is called before the first frame update
    void Start()
    {
        card = new Card();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
