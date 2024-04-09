using UnityEngine;

public class Move : MonoBehaviour
{
    public bool _activeInput = true;
    
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float distance;
    
    private  Rigidbody _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.maxAngularVelocity = 2.5f;
        
    }
    private void FixedUpdate()
    {
        if (_activeInput)
        {
            float sideForce = Input.GetAxis("Horizontal") * _rotationSpeed;
            float forwardForce = Input.GetAxis("Vertical") * _speed;

            _rb.AddRelativeForce(0.0f, 0.0f, forwardForce, ForceMode.VelocityChange);
            _rb.AddRelativeTorque(0.0f, sideForce, 0.0f, ForceMode.VelocityChange);
        }
    }

    public void Jump()
    {
        //code
    }
}
