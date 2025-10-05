using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Vector3 movementDirection;
    public float movementSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(movementDirection, movementSpeed);
    }

    void Move(Vector3 direction, float speed)
    {
        transform.position += direction * (Time.deltaTime * speed);
    }
}
