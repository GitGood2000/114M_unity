using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLifeTime : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1f;
    public float lifeTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		if (lifeTime > 0)
		{
			lifeTime -= Time.deltaTime;
			if (lifeTime <= 0)
			{
				Destruction();
			}
		}

		if (this.transform.position.y <= -20)
		{
			Destruction();
		}
	}

	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.name == "destroyer")
		{
			Destruction();
		}
	}

	void Destruction()
	{
		AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
		Destroy(this.gameObject);
	}
}
