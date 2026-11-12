using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public GameObject Week8Monetisation;


    public GameObject gameOverOverlay;
    public GameObject gameOverText;
    public GameObject gameOverButton;
    public GameObject gameOverScore;
    public TMP_Text gameOverScore_UI;

    public static Score Instance;

    public TMP_Text Score_UI;
    public TMP_Text Ball_UI;

    public int Balls;
    private int Ball_Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverButton.SetActive(false);
        gameOverOverlay.SetActive(false);
        gameOverText.SetActive(false);
        gameOverScore.SetActive(false);
        Week8Monetisation.SetActive(false);
        Balls = 10;
        Ball_UI.text = "Balls: " + Balls;
        Ball_Score = 0;
        Score_UI.text = "Score: " + Ball_Score;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore()
    {
        Ball_Score++;
        Score_UI.text = "Score: " + Ball_Score;
    }

    public void remainingBalls()
    {
        Balls--;
        Ball_UI.text = "Balls: " + Balls;
        if (Balls < 1)
        {
            gameOverButton.SetActive(true);
            gameOverOverlay.SetActive(true);
            gameOverText.SetActive(true);
            gameOverScore.SetActive(true);
            Week8Monetisation.SetActive(true);
            gameOverScore_UI.text = "Score: " + Ball_Score;
        }
        else
        {
            SpawnBall.Instance.ballSpawn();
        }
    }

    private void Awake()
    {
       Instance = this;
    }

}
