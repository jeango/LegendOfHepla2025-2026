using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Vector3 movementDirection;
    public float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movementDirection.normalized * Time.deltaTime * speed;
    }
}
