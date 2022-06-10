using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rb;
    Vector3 _diff;
    Transform _enemyHit;
    [SerializeField] float _rotationSpeed;
    [SerializeField] float _velocity;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _enemyHit = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _diff = mousePos - transform.position;
        _diff = new Vector2(_diff.x, _diff.y);

        if(Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.forward * -_rotationSpeed);
        }

        if (Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.forward * _rotationSpeed);
        }

        _enemyHit.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void FixedUpdate()
    {
        _rb.velocity = _diff * Time.deltaTime * _velocity;
    }
}
