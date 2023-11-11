using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterMove : MonoBehaviour
{
    public float amplitude = 1.0f;   // Amplitude of the sine wave
    public float frequency = 1.0f;   // Frequency of the sine wave
    public float speed = 1.0f;       // Speed of the movement

    private Vector3 initialPosition; // Initial position of the object

    void Start()
    {
        // Save the initial position of the object
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position based on the sine wave
        float x = initialPosition.x + amplitude*3 * Mathf.Sin(Time.time * frequency * speed);
        float y = initialPosition.y + amplitude * Mathf.Sin(Time.time * frequency*5 * speed);
        float z = initialPosition.z;

        // Update the object's position
        transform.position = new Vector3(x, y, z);
    }
}
