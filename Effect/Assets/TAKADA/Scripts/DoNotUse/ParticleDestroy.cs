using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{
	public float existenceHour = 3.0f;

	void Start()
	{

	}

	void Update()
	{
		existenceHour -= Time.deltaTime;
		if(existenceHour < 0.0f)
		{ 
			Destroy(this.gameObject);
		}

	}
}
