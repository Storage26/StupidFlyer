using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStartAnim : MonoBehaviour
{
    public Camera mainCamera;

    public float speed;

    private bool canAnim;

    // Start is called before the first frame update
    void Start()
    {
        canAnim = true;
        mainCamera.orthographicSize = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (canAnim)
        {
            mainCamera.orthographicSize += speed;
        }

        if (mainCamera.orthographicSize >= 5)
        {
            canAnim = false;
        }
    }
}
