using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Vector3 dragOrigin;  
    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) )
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (Input.GetMouseButton(0)){

            Vector3 dragDelta = Input.mousePosition - dragOrigin;
            dragOrigin = Input.mousePosition;

            // Adjust the camera position based on the dragDelta
            transform.Translate(-dragDelta.x * 0.01f, -dragDelta.y * 0.01f, 0);
        }


        if (Input.GetMouseButton(1)) {

            Vector3 dragDelta = Input.mousePosition - dragOrigin;
            dragOrigin = Input.mousePosition;

            // Rotate the camera based on the dragDelta
            transform.Rotate(Vector3.up, -dragDelta.x * 0.1f);
            transform.Rotate(Vector3.right, dragDelta.y * 0.1f);

        }

    }

}
