using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtBar : MonoBehaviour  { 
    [SerializeField] private int hp;
    void Start()
    {
        this.hp = 100;
    }

    void Update()
    {
        
    }

    public void getDamage(int damage){
        this.hp -= damage;
    }
}
