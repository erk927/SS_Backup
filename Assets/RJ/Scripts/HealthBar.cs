using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider healthSlider;

    public void SetMaxHealth(int health){
        healthSlider.maxValue = health;
        healthSlider.value = health;

    }
    public void SetHealth(int health){

        //Put slider component into Health Slider slot so it can be controled from C# script
        healthSlider.value = health;

    }
}
