using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager gameManager;
    private int points;
    public string collisionTag;

    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == collisionTag)
        {
            gameManager.UpdateScore(points);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}