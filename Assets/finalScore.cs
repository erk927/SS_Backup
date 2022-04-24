using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour
{
    public Text Text;
    public void Score()
    {
        GameObject score = GameObject.FindGameObjectWithTag("score");
        playerScore player = score.GetComponent<playerScore>();
        Text.text = "You were infected!\n Your score was " + player.getScore();
    }
}
