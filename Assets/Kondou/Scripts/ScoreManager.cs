using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    [Header("�X�R�A")]static int _score;

    [SerializeField]
    [Header("�X�R�AUI")] Text _scoreText;

    [SerializeField]
    [Header("�n�C�X�R�A")] static int _highScore;

    [SerializeField]
    [Header("�n�C�X�R�AUI")] Text _highScoreText;

    [SerializeField]
    [Header("�J���X�g�X�R�A")] int _maxScore = 99999;
     
    private void Start()
    {
        _highScoreText.text = _highScore.ToString();
    }
    private void Update()
    {
        if(_score > _maxScore)
        {
            _score = _maxScore;
        }
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

