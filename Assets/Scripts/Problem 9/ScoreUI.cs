using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [Header("UI")]
    public Text score;
    public Text highScore;

    public static int Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        score.text = Score.ToString();
        SaveHighscore();
    }

    public void SaveHighscore()
    {     
        if (Score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", Score);
            highScore.text = Score.ToString();
        }
    }
}
