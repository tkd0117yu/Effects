using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectChangeTest : MonoBehaviour
{
	public GameObject[] EffectList = new GameObject[5];

    // Start is called before the first frame update
    void Start()
    {
		EffectList[0].GetComponent<ParticleSystem>().Stop();
		EffectList[1].GetComponent<ParticleSystem>().Stop();
		EffectList[2].GetComponent<ParticleSystem>().Stop();
		EffectList[3].GetComponent<ParticleSystem>().Stop();
		EffectList[4].GetComponent<ParticleSystem>().Stop();
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			EffectList[0].GetComponent<ParticleSystem>().Play();
			EffectList[1].GetComponent<ParticleSystem>().Stop();
			EffectList[2].GetComponent<ParticleSystem>().Stop();
			EffectList[3].GetComponent<ParticleSystem>().Stop();
			EffectList[4].GetComponent<ParticleSystem>().Stop();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			EffectList[0].GetComponent<ParticleSystem>().Stop();
			EffectList[1].GetComponent<ParticleSystem>().Play();
			EffectList[2].GetComponent<ParticleSystem>().Stop();
			EffectList[3].GetComponent<ParticleSystem>().Stop();
			EffectList[4].GetComponent<ParticleSystem>().Stop();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			EffectList[0].GetComponent<ParticleSystem>().Stop();
			EffectList[1].GetComponent<ParticleSystem>().Stop();
			EffectList[2].GetComponent<ParticleSystem>().Play();
			EffectList[3].GetComponent<ParticleSystem>().Stop();
			EffectList[4].GetComponent<ParticleSystem>().Stop();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			EffectList[0].GetComponent<ParticleSystem>().Stop();
			EffectList[1].GetComponent<ParticleSystem>().Stop();
			EffectList[2].GetComponent<ParticleSystem>().Stop();
			EffectList[3].GetComponent<ParticleSystem>().Play();
			EffectList[4].GetComponent<ParticleSystem>().Stop();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			EffectList[0].GetComponent<ParticleSystem>().Stop();
			EffectList[1].GetComponent<ParticleSystem>().Stop();
			EffectList[2].GetComponent<ParticleSystem>().Stop();
			EffectList[3].GetComponent<ParticleSystem>().Stop();
			EffectList[4].GetComponent<ParticleSystem>().Play();
		}

	}
}
