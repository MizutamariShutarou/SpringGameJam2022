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
    [Header("最終スコアUI")] Text _fainalScoreText;

    [SerializeField]
    [Header("ハイスコア")] static int _highScore;

    [SerializeField]
    [Header("ハイスコアUI")] Text _highScoreText;
    [SerializeField]
    [Header("最終ハイスコアUI")] Text _fainalHighScoreText;

    [SerializeField]
    [Header("カンストスコア")] int _maxScore = 99999; 
     
    private void Start()
    {
        _score = 0;
        _highScoreText.text = _highScore.ToString();
    }
    private void Update()
    {
        if(_score > _maxScore)
        {
            _score = _maxScore;
        }
        if(TimeController.Instance._isGameOver)
        {
            HighScore();
        }
        _scoreText.text = _score.ToString();
        _fainalScoreText.text = _score.ToString();
        _fainalHighScoreText.text = _highScore.ToString();
    }
    void HighScore()
    {
        if(_highScore < _score)
        {
            _highScore = _score;
            _highScoreText.text = _highScore.ToString();
        }
    }
    public int GetScore(int getScore)
    {
        _score += getScore;
        return _score;
    }
}

