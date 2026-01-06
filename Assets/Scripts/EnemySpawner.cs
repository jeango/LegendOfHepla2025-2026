using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnDelay;
    public float spawnInterval;
    public float minYPosition;
    public float maxYPosition;
    
    
    void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnDelay, spawnInterval);
    }

    void Spawn()
    {
        float yPosition = Random.Range(minYPosition, maxYPosition);
        Vector3 spawnPosition = new Vector3(transform.position.x, yPosition);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
