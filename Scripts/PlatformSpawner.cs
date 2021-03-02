using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public int PlatformCount;
    public float Width = 2f;
    public float minY1 = .9f;
    public float maxY1 = 1.5f;
    public GameObject BrokenplatformPrefab;
    public int BrokenPlatformCount;
    public GameObject CrownPrefab;
    public float minY2 = 3f;
    public float maxY2 = 8f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 SpawnPos = new Vector3();
        for (int Counter = 0; Counter < PlatformCount; Counter++ )
        {
            SpawnPos.x = Random.Range(-Width, +Width);
            SpawnPos.y += Random.Range(minY1, maxY1);
            Instantiate(platformPrefab, SpawnPos, Quaternion.identity);
            
        }
        Vector3 BrokenSpawnPos = new Vector3();
        for (int F = 0; F < PlatformCount; F++)
        {
            BrokenSpawnPos.x = Random.Range(-Width, +Width);
            BrokenSpawnPos.y += Random.Range(minY1, maxY1);
            Instantiate(BrokenplatformPrefab, BrokenSpawnPos, Quaternion.identity);
        }
        SpawnPos.y += Random.Range(minY1, maxY1);
        Instantiate(CrownPrefab, SpawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
