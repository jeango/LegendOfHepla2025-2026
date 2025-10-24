using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float delayBeforeFirstSpawn;
    public float spawnInterval;
    public float minYSpawnPosition;
    public float maxYSpawnPosition;
    

    void Spawn()
    {
        float randomY = Random.Range(minYSpawnPosition, maxYSpawnPosition);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), delayBeforeFirstSpawn, spawnInterval);
    }

    void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
}
