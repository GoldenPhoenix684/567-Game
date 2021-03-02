using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject GemPrefab;
    public int GemCount;
    public GameObject enemyPrefab;
    public int enemyCount;
    public float Width = 2f;
    public float minY1 = 3f;
    public float maxY1 = 8f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 SpawnPos = new Vector3();
        for (int Counter = 0; Counter < enemyCount; Counter++)
        {
            SpawnPos.x = -3;
            SpawnPos.y += Random.Range(minY1, maxY1);
            Instantiate(enemyPrefab, SpawnPos, Quaternion.identity);
        }
        Vector3 GemSpawnPos = new Vector3();
        for (int Counter = 0; Counter < GemCount; Counter++)
        {
            GemSpawnPos.x = Random.Range(-Width, +Width);
            GemSpawnPos.y += Random.Range(minY1, maxY1);
            Instantiate(GemPrefab, GemSpawnPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
