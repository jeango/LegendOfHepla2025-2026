using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float maxYPosition;
    public float minYPosition;

    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        float yPosition = Random.Range(minYPosition, maxYPosition);
        Vector3 position = new Vector3(transform.position.x, yPosition);
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
