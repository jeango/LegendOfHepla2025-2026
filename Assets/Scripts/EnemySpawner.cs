using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float minYPosition;
    public float maxYPosition;
    public float spawnInterval;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnInterval, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        float randomY = Random.Range(minYPosition, maxYPosition);
        Vector3 position = new Vector3(transform.position.x, randomY);
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
