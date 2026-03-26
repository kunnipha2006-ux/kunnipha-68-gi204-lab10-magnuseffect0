using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AngularvelocityControl : MonoBehaviour
{
    public float angularSpeed = 1;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            _rb.angularVelocity = new Vector3 (0, angularSpeed, 0);
        }
    }
}
