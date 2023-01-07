using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private Slider slider;
    // Start is called before the first frame update
    public void setHP(int hp){
        this.hp = hp;
    }
    public void inicia()
    {
        this.slider.maxValue = 100;
        this.slider.minValue = 0;
        this.slider.value = this.hp;
    }

    // Update is called once per frame




    public int getHP(){
        return this.hp;
    }




    public void getDamage(int damage){
        this.hp -= damage;
        this.slider.value = this.hp;
    }

    public void heal(int heal){
        this.hp += heal;
        if(this.hp >= 100)
            this.hp = 100;
        this.slider.value = this.hp;
    }
}
