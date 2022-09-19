using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject spawnProp;
    public bool stopSpawning = true;
    public float spawnTime;
    public float spawnDelay;

    // Use this for initialization
    void Start()
    {
        
    }

    public void SpawnStart()
    {
        if (stopSpawning)
        {
            stopSpawning = false;
            InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        }
    }

    public void SpawnStop()
    {
        stopSpawning = true;
    }

    public void SpawnObject()
    {
        Instantiate(spawnProp, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}