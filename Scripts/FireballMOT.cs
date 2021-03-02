using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMOT : MonoBehaviour
{
    public float speed = 5;
    public float direction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
