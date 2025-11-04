using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector3 movementDirection;
    public float movementSpeed;
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
            Move(movementDirection, movementSpeed);
        }
    }
 
    // FixedUpdate is called once per physics update
    void FixedUpdate()
    {
        if (body && body.bodyType == RigidbodyType2D.Dynamic)
        {
            MoveDynamic(movementDirection, movementSpeed);
        }
    }

    void MoveDynamic(Vector3 direction, float speed)
    {
        body.linearVelocity = direction.normalized * speed;
    }
    
    void Move(Vector3 direction, float speed)
    {
        transform.position += direction.normalized * (Time.deltaTime * speed);
    }

    
}
