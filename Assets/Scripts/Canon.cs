using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
