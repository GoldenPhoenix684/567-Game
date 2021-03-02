using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDOS : MonoBehaviour
{
    public float xlimit1 = 9f;
    public float xlimit2 = -9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xlimit1)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < xlimit2)
        {
            Destroy(gameObject);
        }
    }
}
