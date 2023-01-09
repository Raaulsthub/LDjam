using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class CardEventArgs : EventArgs
{
    public Card card;

    public CardEventArgs(Card e)
    {
        card = e;
    }
}
