using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEffect : MonoBehaviour {

    public float spawnEffectTime = 2;
    public float pause = 1;
    public AnimationCurve fadeIn;

    ParticleSystem ps;
    float timer = 0;
    Renderer _renderer;

    int shaderProperty;

	public bool startTrigger;

	void Start ()
    {
        shaderProperty = Shader.PropertyToID("_cutoff");
        _renderer = GetComponent<Renderer>();
		
		startTrigger = false;

	}
	
	void Update ()
    {
		if (startTrigger)
		{
			this.GetComponent<MeshRenderer>().enabled = true;

			if (timer < spawnEffectTime + pause)
			{
				timer += Time.deltaTime;
			}
			else
			{
				timer = 0;
			}


			_renderer.material.SetFloat(shaderProperty, fadeIn.Evaluate(Mathf.InverseLerp(0, spawnEffectTime, timer)));
		}
    }
}
