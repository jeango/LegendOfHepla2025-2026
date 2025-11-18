using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector3 movementDirection;
    public float movementSpeed;
    public Rigidbody2D body;

    // Update is called once per frame
    void Update()
    {
        if (body == false || body.bodyType == RigidbodyType2D.Kinematic)
        {
            Move(movementDirection, movementSpeed);
        }
    }

    void FixedUpdate()
    {
        if (body && body.bodyType == RigidbodyType2D.Dynamic)
        {
            MoveDynamic(movementDirection, movementSpeed);
        }
    }

    private void MoveDynamic(Vector3 direction, float speed)
    {
        body.linearVelocity = direction.normalized * speed;
    }
    
    private void Move(Vector3 direction, float speed)
    {
        transform.position += direction.normalized * (Time.deltaTime * speed);
    }

    public void SetDirectionFromInput(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
    }
}
