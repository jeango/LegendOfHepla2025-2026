using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public WeightedGameObject[] enemyPrefabList;
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
        GameObject enemyPrefab = GenerateRandomEnemy();
        float randomY = Random.Range(minYSpawnPosition, maxYSpawnPosition);
        Vector3 randomPos = new Vector3(transform.position.x, randomY);
        Instantiate(enemyPrefab, randomPos, Quaternion.identity);
    }

    private GameObject GenerateRandomEnemy()
    {
        int roll = Random.Range(0, CalculateTotalWeight()+1);
        int cursor = 0;
        for (int i = 0; i < enemyPrefabList.Length; i++)
        {
            cursor += enemyPrefabList[i].weight;
            if (cursor >= roll)
            {
                return enemyPrefabList[i].gameObject;
            }
        }

        return null;
    }

    private int CalculateTotalWeight()
    {
        int totalWeight = 0;
        foreach (var enemyWeight in enemyPrefabList)
        {
            totalWeight += enemyWeight.weight;
        }
        return totalWeight;
    }
}

[System.Serializable]
public struct WeightedGameObject
{
    public int weight;
    public GameObject gameObject;
}
