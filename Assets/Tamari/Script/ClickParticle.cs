using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickParticle : MonoBehaviour
{
    [SerializeField] ParticleSystem _pS;
    GameObject _obj;
    private Vector2 mousePosition;


    void Start()
    {
        _obj = GameObject.Find("Click");
        _pS = _obj.GetComponentInChildren<ParticleSystem>();
        _obj.SetActive(false);
        _pS.Stop();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            Instantiate(_pS, Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);
            _obj.SetActive(true);
            _pS.Play();
        }

    }
}