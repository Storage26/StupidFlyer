using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;

    public GameObject obstacle;

    // Update is called once per frame
    void Update()
    {
        obstacle.transform.Translate(-speed, 0, 0);

        if (obstacle.transform.position.x <= -11.3f)
        {
            Destroy(obstacle);
        }
    }
}
