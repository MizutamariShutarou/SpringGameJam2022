using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastSpawn : MonoBehaviour
{
    [SerializeField] GameObject _lastSpawner;
    private void Update()
    {
        if(TimeController.Instance._isLast)
        {
            _lastSpawner.SetActive(true);
        }
    }
}
