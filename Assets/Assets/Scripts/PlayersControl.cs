using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayersControl : MonoBehaviour
{

    // Use this for initialization
    public Animator PlayerAnimation;
    //public Animator PlayerAnimation_2;
    public int myScore;
    public int Score_2;
    public Text myText;
    public Text enemyText;
    private float time = 0.0f;
    public float interpolationPeriod = 1.0f;
    public bool P_pressed;

    //public Text text_2;

    void Start()
    {
        Time.timeScale = 1;
        //myText.GetComponent<Text>();
        //enemyText.GetComponent<Text>();
        //text_2.GetComponent<Text>();
       // text_2.text = " ";
        myText.text = " ";
        enemyText.text = " ";
        SetCountText();
        myScore = 0;
        Score_2 = 0;
        P_pressed = false;


    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerAnimation.SetTrigger("attacking");
            myScore++;
            SetCountText();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            if (P_pressed == false)
            {
                P_pressed = true;
                Time.timeScale = 0;
            }
            else
            {
                P_pressed = false;
                Time.timeScale = 1;
            }
        }
        else if (time >= interpolationPeriod)
        {
            PlayerAnimation.SetTrigger("EnemyAttacking");
           // if(PlayerAnimation.)
                Score_2++;
            time = time - interpolationPeriod;
            SetCountText();
        }
        else if (time < interpolationPeriod)
            time += Time.deltaTime;
    }     
    void SetCountText()
    {
        myText.text = "Score: " + myScore.ToString();
        enemyText.text = "Score: " + Score_2.ToString();
        if (myScore >= 30)
        {
            Time.timeScale = 0;
           // text_2.text = "You Win!";
            SceneManager.LoadScene("GameOverWin");
            //loadGameOverScene(GameOver);


        }
        else if (Score_2 >= 30)
        {
            Time.timeScale = 0;
         //   text_2.text = "You Lose!";
            SceneManager.LoadScene("GameOverLose");

            //loadGameOverScene(GameOver);
        }
    }
    /*void loadGameOverScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }*/
}

  