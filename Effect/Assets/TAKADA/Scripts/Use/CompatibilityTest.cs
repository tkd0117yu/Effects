using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompatibilityTest : MonoBehaviour
{
	public ParticleSystem[] particleSystemList = new ParticleSystem[7];
	public AudioSource audioSource;
	public AudioClip[] audioClipList = new AudioClip[7];

	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			audioSource.Stop();
			particleSystemList[0].Stop();

			audioSource.PlayOneShot(audioClipList[0]);
			particleSystemList[0].Play();
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			audioSource.Stop();
			particleSystemList[1].Stop();

			audioSource.PlayOneShot(audioClipList[1]);
			particleSystemList[1].Play();
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			audioSource.Stop();
			particleSystemList[2].Stop();

			audioSource.PlayOneShot(audioClipList[2]);
			particleSystemList[2].Play();
		}
		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			audioSource.Stop();
			particleSystemList[3].Stop();

			audioSource.PlayOneShot(audioClipList[3]);
			particleSystemList[3].Play();
		}
		if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			audioSource.Stop();
			particleSystemList[4].Stop();

			audioSource.PlayOneShot(audioClipList[4]);
			particleSystemList[4].Play();
		}
		if (Input.GetKeyDown(KeyCode.Alpha6))
		{
			audioSource.Stop();
			particleSystemList[5].Stop();

			audioSource.PlayOneShot(audioClipList[5]);
			particleSystemList[5].Play();
		}
		if (Input.GetKeyDown(KeyCode.Alpha7))
		{
			audioSource.Stop();
			particleSystemList[6].Stop();

			audioSource.PlayOneShot(audioClipList[6]);
			particleSystemList[6].Play();
		}

	}
}
