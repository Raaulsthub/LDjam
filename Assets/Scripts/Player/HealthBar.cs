using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private int hp;
    // Start is called before the first frame update
    void Start()
    {
        this.hp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getHP(){
        return this.hp;
    }

    public void getDamage(int damage){
        this.hp -= damage;
    }

    public void heal(int heal){
        this.hp += heal;
    }
}
