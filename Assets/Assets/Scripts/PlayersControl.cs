/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    public Text text_2;

    void Start()
    {
        //myText.GetComponent<Text>();
        //enemyText.GetComponent<Text>();
        //text_2.GetComponent<Text>();
        text_2.text = " ";
        myText.text = " ";
        enemyText.text = " ";
        SetCountText();
        myScore = 0;
        Score_2 = 0;



    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerAnimation.SetTrigger("attacking");
            myScore++;
        }
        else
        {
            time += Time.deltaTime;
            while (time < interpolationPeriod)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    PlayerAnimation.SetTrigger("attacking");
                    myScore++;
                }
            }
                //if (time >= interpolationPeriod)
                //{
                time = time - interpolationPeriod;
            PlayerAnimation.SetTrigger("attacking");
            Score_2++;
                SetCountText();
            //}
        }

    }
    void SetCountText()
    {
        myText.text = "Score: " + myScore.ToString();
        enemyText.text = "Score: " + Score_2.ToString();
        if (myScore >= 30)
        {
            text_2.text = "You Win!";
        }
        else if (Score_2 >= 30)
        {
            text_2.text = "You Lose!";
        }
    }
}

*/