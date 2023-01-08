using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public List<Card> allyCards = new List<Card>();
    [SerializeField] public List<Card> enemyCards = new List<Card>();
    [SerializeField] GameObject[] allyField;
    [SerializeField] GameObject[] enemyField;


    void Start(){
        Display();
    }


    private void Display(){

    }
}