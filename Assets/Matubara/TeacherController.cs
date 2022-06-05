using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherController : MonoBehaviour
{
    [SerializeField] float m_lifeTime = 5f;
    [SerializeField] Transform _target;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, m_lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = transform.position - _target.position;
    }
}
