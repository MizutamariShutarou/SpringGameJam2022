using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rd;
    Vector3 _diff;
    [SerializeField] float _rotationSpeed;
    [SerializeField] float _velocity;
    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _diff = mousePos - transform.position;
        _diff = new Vector3(_diff.x, _diff.y,0);

        if (Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.forward * _rotationSpeed);
        }
    }

    private void FixedUpdate()
    {
        _rd.velocity = _diff * Time.deltaTime * _velocity;
    }
}
