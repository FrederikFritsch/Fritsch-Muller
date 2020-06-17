using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBats : MonoBehaviour
{

    public GameObject batPrefab;
    public Vector3 position;
    void Start()
    {
        InvokeRepeating("spawnBat", 0, 5);
    }

    void spawnBat() {
        position = new Vector3(Random.Range(-8.0f, 8.0f), 10.0f, 0.0f);
        Instantiate(batPrefab, position, Quaternion.identity);
    }
}
