using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector3 movementDirection;
    public float speed;
    public Rigidbody2D body;

    public void SetDirectionFromInput(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (body == null || body.bodyType == RigidbodyType2D.Kinematic)
        {
            Move(movementDirection);
        }
    }

    void FixedUpdate()
    {
        if (body != null && body.bodyType == RigidbodyType2D.Dynamic)
        {
            MoveDynamic(movementDirection);
        }
    }

    void Move(Vector3 direction)
    {
        transform.position += direction.normalized * (Time.deltaTime * speed);
    }

    void MoveDynamic(Vector3 direction) 
    {
        body.linearVelocity = direction.normalized * speed;
    }
    
}
