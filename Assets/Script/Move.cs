using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float _speedMove;
    [SerializeField] float _speedRotate;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            Forward();

        if (Input.GetKey(KeyCode.S))
            Back();

        if (Input.GetKey(KeyCode.A))
            Left();

        if (Input.GetKey(KeyCode.D))
            Right();
    }

    void Forward()
    {
        rb.AddRelativeForce(Vector3.forward * _speedMove, ForceMode.Acceleration);
    }

    void Back()
    {
        rb.AddRelativeForce(Vector3.back * _speedMove, ForceMode.Acceleration);
    }

    void Left()
    {
        //rb.AddRelativeForce(Vector3.left * _speedMove);
        gameObject.transform.Rotate(Vector3.down * _speedRotate);

    }

    void Right()
    {
        //rb.AddRelativeForce(Vector3.right * _speedMove);
        gameObject.transform.Rotate(Vector3.up * _speedRotate);

    }
}
