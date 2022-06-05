using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // �N���G
    [SerializeField] GameObject[] _enemies;
    // �G���N������
    [SerializeField] float _distance;

    IEnumerator _spawn;

    void Start()
    {
        _spawn = Spawn();
        StartSpawn();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) EndSpawn();
    }

    // �G�̃X�|�[���J�n
    public void StartSpawn() => StartCoroutine(_spawn);
    // �G�̃X�|�[���I��
    public void EndSpawn() => StopCoroutine(_spawn);

    // �G���X�|�[��������
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(_distance);
            int r = Random.Range(0, _enemies.Length);
            Instantiate(_enemies[r], transform.position, Quaternion.identity);
        }
    }
}
