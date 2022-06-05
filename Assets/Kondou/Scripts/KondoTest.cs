using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KondoTest : MonoBehaviour
{
    ScoreManager _sM = new ScoreManager();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _sM.GetScore(1);
    }
}
