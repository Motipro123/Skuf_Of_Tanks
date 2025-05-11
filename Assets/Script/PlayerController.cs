using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float rotationTorque = 100.0f;
    [SerializeField] private float rotationSpeed = 100.0f;
    public Vector3 rotationAxis = Vector3.up;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * _speed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * _speed;

        _rb.AddTorque(rotationAxis * h* rotationSpeed * rotationTorque);
        transform.Translate(0, 0, v);
        //_rb.velocity = new Vector3(h, _rb.velocity.y, v);
    }

}
