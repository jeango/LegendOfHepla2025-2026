using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float minYPosition;
    public float maxYPosition;

    public float delay;
    public float spawnRate;
    
    private void Start()
    {
        InvokeRepeating(nameof(Spawn),delay,spawnRate);
    }

    void Update()
    {
    }

    void Spawn()
    {
        float yPosition = Random.Range(minYPosition, maxYPosition);
        Vector3 position = new Vector3(transform.position.x, yPosition);
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
