using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScore : MonoBehaviour
{
    //private int score;

    // Start is called before the first frame update
    void Start()
    {
        //file call, if file doesn't exist create
        //if file is created highScores = {0,0,0,0,0,0,0,0,0,0}
        //else loop over file and place ints in highScores;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadScores()
    {
        //read from file if file exists
    }

    void saveScore(int[] highScores)
    {
        //loop over highScores,
        /*for(int i = 0; i < highScores.length && i < 10; i++)
         *  {
         *      if(player.score > highScore[i]
         *      {
         *          shiftScores(i);
         *          highScore[i] = player.score;
         *          write to file;
         *          break;
         *      }
         *  }
         */
    }

    private void shiftScores(int i)
    {
        /*for(int index = highScores.length; index > i; index--)
        {
            highScores[index] = highScores[index - 1];
        }*/
    }

    // Method to increase score
    /*void increaseScore()
    {
        score += 100;
    }

    int getScore()
    {
        return score;
    }
    */
}
