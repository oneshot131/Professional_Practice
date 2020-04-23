using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // Variables
    int totalScore;
    int score = 0;
    static Game Instance;
    public int nextLevel;

    // Sey up new game
    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this.gameObject);
    }

    public static void AddToScore(int points)
    {
        // Increment Score
        Instance.score += 1;

        // Next Level
        if (Instance.score == 6)
        {
            // Go to level after current
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public static int GetScore()
    {
        // Display score
        return +Instance.score;
    }


    void update()
    {

    }
}
