using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject bola;
    public GameObject player1;
    public GameObject player1goal1;
    public GameObject player2;
    public GameObject player2goal2;


    public Text player1Text;
    public Text player2Text;

    private int player1Score;
    private int player2Score;

    public bool IAGame;

    public int maxScore = 7;


    public void CheckVictory(){

        if(player1Score >= maxScore){
            SceneManager.LoadScene("VictoryPlayer1");


        }

        if(player2Score >= maxScore){
            SceneManager.LoadScene("VictoryPlayer2");

        }

    }

    public void Player1Scored()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        CheckVictory();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        CheckVictory();
        ResetPosition();
    }

    private void ResetPosition()
    {
    

        if (IAGame)
        {
            bola.GetComponent<Ball>().Reset();;
            player2.GetComponent<Players>().Reset();
        }
        else 
        {
            
            bola.GetComponent<Ball>().Reset();;
            player2.GetComponent<Players>().Reset();
            player1.GetComponent<Players>().Reset();
        }
    }
}
