using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shieldBar : MonoBehaviour
{
 public Slider shieldSlider;

    public void SetMaxShield(int shield){
        shieldSlider.maxValue = shield;
        shieldSlider.value = shield;

    }
    public void Setshield(int shield){

        //Put slider component into shield Slider slot so it can be controled from C# script
        shieldSlider.value = shield;

    }
}
