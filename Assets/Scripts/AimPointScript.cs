using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimPointScript : MonoBehaviour
{

    Camera camera; 
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraCenter = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, camera.nearClipPlane));
        cameraCenter.z = transform.position.z;
        transform.position = cameraCenter;
    }
}
