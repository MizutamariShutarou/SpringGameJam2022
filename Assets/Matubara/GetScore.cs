using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{

    [SerializeField] int _waterScore;
    [SerializeField] int _garbageScore;
    [SerializeField] int _teacherScore;
    [SerializeField] ScoreManager _sm;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            _sm.GetScore(_waterScore);
        }
        else if (collision.gameObject.CompareTag("Garbage"))
        {
            _sm.GetScore(_garbageScore);
        }
        else if (collision.gameObject.CompareTag("Teacher"))
        {
            _sm.GetScore(_teacherScore);
        }

    }
}
