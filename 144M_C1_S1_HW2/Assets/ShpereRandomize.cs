using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpereRandomize : MonoBehaviour
{
    public GameObject Sphere;
    public Renderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = Sphere.GetComponent<Renderer>();
        //gameObject.GetComponent<Button>().onClick.AddListener(SphereChange);
    }

    public void SphereChange() 
    {
        //audioSource.PlayOneShot(clip, volume);
        Sphere.transform.localScale = new Vector3(Random.Range(0.5f, 3f), Random.Range(0.5f, 3f), Random.Range(0.5f, 3f));
        meshRenderer.sharedMaterial.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
