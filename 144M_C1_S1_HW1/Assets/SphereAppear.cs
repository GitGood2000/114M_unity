using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAppear : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject sphere;
    bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && (!check))
        {
            Instantiate(sphere, spawnPos.position, spawnPos.rotation);
            check = true;
        }
    }
}
