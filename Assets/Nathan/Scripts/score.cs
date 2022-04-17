using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to increase score
    void increaseScore()
    {
        score += 100;
    }

    int getScore()
    {
        return score;
    }
}
