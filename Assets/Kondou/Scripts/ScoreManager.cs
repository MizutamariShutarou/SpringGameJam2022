using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    [Header("スコア")]static int _score;

    [SerializeField]
    [Header("スコアUI")] Text _scoreText;

    [SerializeField]
    [Header("ハイスコア")] static int _highScore;

    [SerializeField]
    [Header("ハイスコアUI")] Text _highScoreText;

    private void Start()
    {
        _highScoreText.text = _highScore.ToString();
    }
    private void Update()
    {
        _scoreText.text = _score.ToString();
        HighScore();
    }
    void HighScore()
    {
        if(_highScore < _score)
        {
            _highScore = _score;
            _highScoreText.text = _highScore.ToString();
        }
    }
}

