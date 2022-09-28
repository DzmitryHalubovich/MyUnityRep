using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    private float spawnPositionZ = 30.0f;
    private float spawnPositionXmax = 30;
    private float spawnDelay = 1.0f;
    private float spawnColdawn = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",spawnDelay,spawnColdawn);
    }

    void SpawnEnemy()
    {
        Vector3 position = new Vector3(Random.Range(-spawnPositionXmax, spawnPositionXmax), 0, spawnPositionZ);
        Instantiate(enemy, position, enemy.transform.rotation);
    }
}
