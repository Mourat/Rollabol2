using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue movementValue)
    {
        var movementVector = movementValue.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        
    }
}
