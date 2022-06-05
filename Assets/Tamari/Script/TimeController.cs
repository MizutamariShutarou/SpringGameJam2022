using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    [Header("制限時間"), SerializeField] float _countTime;
    [SerializeField] Text _timeText;
    [SerializeField] GameObject _gameOverPanel;
    [SerializeField] List<GameObject> _gameObjectList;

    //bool _isGameOver;
    void Update()
    {
        _countTime -= Time.deltaTime;

        _timeText.text = "残り" + _countTime.ToString("f1");

        if(_countTime <= 0)
        {
            _gameObjectList.ForEach(e => e.SetActive(false));
            _timeText.text = "お掃除完了！";
            _gameOverPanel.SetActive(true);
        }
    }
}
