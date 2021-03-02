using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform PlayerPosition;

    public void Update()
    {
        if (PlayerPosition.position.y > transform.position.y)
        {
            transform.position = new Vector3(0f, PlayerPosition.position.y, -5);
        }
    }
}
