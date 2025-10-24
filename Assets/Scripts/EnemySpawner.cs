using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float firstSpawnDelay;
    public float spawnInterval;

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
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
