using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float minYSpawnPosition;
    public float maxYSpawnPosition;
    public float spawnDelay;
    public float spawnRate;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnDelay, spawnRate);
    }
    
    void Spawn()
    {
        float randomY = Random.Range(minYSpawnPosition, maxYSpawnPosition);
        Vector3 randomPos = new Vector3(transform.position.x, randomY);
        Instantiate(enemyPrefab, randomPos, Quaternion.identity);
    }
    
}
