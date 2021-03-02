using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager gameManager;
    private Rigidbody2D rb2d;
    private float JumpForce = 11f;
    public GameObject projectilePrefab;
    public Transform firePoint;
    private float Speed = 5f;
    private float Directiony = 0f;
    private int points = 10;
    public string collisionTag;
    public int life = -1;
    public float Directionx = 0f;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSource3;


    // Start is called before the first frame update
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameManager>();

    }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        Directiony = rb2d.velocity.y;
        Directionx = rb2d.velocity.x;
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Speed * Time.deltaTime * horizontalInput);
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab, firePoint.position, projectilePrefab.transform.rotation);
            audioSource3.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // this means the player will only jump is they are going down

        if (Directiony <= 0f)
        {


            //this will make the player jump when they hit a platform
            if (collision.gameObject.CompareTag("Platform"))
            {
                rb2d.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
                gameManager.UpdateScore(points);
                

            }
            // this will make the player jump as well as destroy the platform they hit it
            if (collision.gameObject.CompareTag("BrokenPlatform"))
            {

                rb2d.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
                gameManager.UpdateScore(points);
                Destroy(collision.gameObject);
                audioSource.Play();

            }

        }
        if (collision.gameObject.tag == collisionTag)
        {

            Destroy(collision.gameObject);
            gameManager.UpdateLives(life);
            if (gameManager.Lives < 1)
            {
                SceneManager.LoadScene("GameOverMenu");
            }
        }
        if (collision.gameObject.CompareTag("Gem"))
        {
            gameManager.UpdateScore(points);
            Destroy(collision.gameObject);
            audioSource2.Play();
        }
        if (collision.gameObject.CompareTag("Crown"))
        {
            audioSource2.Play();
            gameManager.UpdateScore(points * 20);
            SceneManager.LoadScene("WinScreen");
        }





    }
}
