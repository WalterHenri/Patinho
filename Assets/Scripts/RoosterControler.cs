using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterControler : MonoBehaviour
{
    public GameObject prefab; // Reference to your prefab
    public int numberOfInstances = 10; // Set the number of instances you want

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        for (int i = 0; i < numberOfInstances; i++)
        {
            // Instantiate the prefab at a position (you can customize this)
            GameObject rooster = Instantiate(prefab, new Vector3(-2 + i * 3, 0, 1), Quaternion.identity);
            RoosterMove script = rooster.GetComponent<RoosterMove>();
            script.phase = (float)i/numberOfInstances;
        }
    }
}
