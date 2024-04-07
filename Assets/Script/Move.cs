using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * _rotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * _speed;

        _rb.AddRelativeForce(0.0f, 0.0f, forwardForce);
        _rb.AddRelativeTorque(0.0f, sideForce, 0.0f);
    }
}
