using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float firstSpawnDelay;
    public float spawnInterval;
    public float minYSpawnPosition;
    public float maxYSpawnPosition;

    // Update is called once per frame
    void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), firstSpawnDelay, spawnInterval);
    }

    void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    
    void Spawn()
    {
        float randomY = Random.Range(minYSpawnPosition, maxYSpawnPosition);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
