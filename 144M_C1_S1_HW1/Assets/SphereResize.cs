using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereResize : MonoBehaviour
{
    bool check = false;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1) && (!check))
        {
            transform.localScale += new Vector3 (0, 1, 0);
            check = true;
            audioSource.PlayOneShot(clip, volume);
        }
    }
}
