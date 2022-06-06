using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    [Header("êßå¿éûä‘"), SerializeField] float _countTime;
    [SerializeField] Text _timeText;
    [SerializeField] GameObject _gameOverPanel;
    [SerializeField] List<GameObject> _gameObjectList;
    public bool _isGameOver;
    public static TimeController Instance { get; private set; } = default;
    private void Awake()
    {
        Instance = this;
    }
    
    void Update()
    {
        _countTime -= Time.deltaTime;

        _timeText.text = "écÇË" + _countTime.ToString("f1");

        if(_countTime <= 0)
        {
            _isGameOver = true;
            Debug.Log(_isGameOver);
            _gameObjectList.ForEach(e => e.SetActive(false));
            _timeText.text = "Ç®ë|èúäÆóπ";
            _gameOverPanel.SetActive(true);
        }
    }
}
