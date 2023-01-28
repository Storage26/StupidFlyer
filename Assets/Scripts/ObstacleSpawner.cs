using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float interval;

    public GameObject prefab;

    public float nextTime;

    // Start is called before the first frame update
    void Start()
    {
        nextTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTime)
        {
            Instantiate(prefab, new Vector3(prefab.transform.position.x, Random.Range(3.15f, -3.15f), prefab.transform.position.z), Quaternion.identity);
            nextTime = Time.time + interval;
        }
    }
}
