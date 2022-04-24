using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScore : MonoBehaviour
{
    [HideInInspector]public Text Score;
    private int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        Score.text = "Score: " + currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + currentScore; 
    }

    public void loadScore()
    {
        PlayerPrefs.GetInt("highscore");
    }

    public void saveScore()
    {
        if(currentScore > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", currentScore);
        }
    }

    //Method to increase score
    public void increaseScore()
    {
        currentScore += 100;
        //Debug.Log("Score increased");
        Score.text = "Score: " + currentScore;
        //Debug.Log("Text updated");
    }

    public int getScore()
    {
        return currentScore;
    }
}
