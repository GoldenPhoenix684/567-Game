using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyComtroller : MonoBehaviour
{
    public Vector3 Position;
    private float spawnDelay;
    public GameObject Bullet;
   
    // Start is called before the first frame update
    void Start()
    {
        {
            
            Position = transform.position; //   Use the position of the empty GameObject as the position to spawn the obstacles.
            spawnDelay = Random.Range(1.5f, 2f);
            Invoke("SpawnBullet", spawnDelay);
        }
    }

    
    private void SpawnBullet()
    {
        
        GameObject tmp = Instantiate(Bullet, Position, Bullet.transform.rotation); // Store a temporary copy of the obstacle when it spawns.
        Destroy(tmp, 25f);   // Delete the obstacle after a certain amount of time.
        spawnDelay = Random.Range(.7f, 2f);
        Invoke("SpawnBullet", spawnDelay);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            Destroy(gameObject);

        }
    }
}
