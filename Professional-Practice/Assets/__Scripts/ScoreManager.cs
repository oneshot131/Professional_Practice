using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public Text scoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        scoreText.text = "X" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // Display score as String
       // scoreText.text = Game.GetScore().ToString();
    }
}
