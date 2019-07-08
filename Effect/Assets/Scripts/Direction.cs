using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
	private ParticleManagement particleManagementCS;


	//使用するパーティクルの列挙
	public enum ParticleType
	{
		Particle_1 = 0,
		Particle_2 = 1,
		Particle_3 = 2,
		Particle_4 = 3,
		Particle_5 = 4,
		Particle_6 = 5,
		Particle_7 = 6,
	}
	//パーティクル選択用
	[SerializeField] ParticleType particleType = ParticleType.Particle_5;

	void Start()
	{
		//管理しているスクリプトを取得
		particleManagementCS = GameObject.Find("ParticleManager").GetComponent<ParticleManagement>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//パーティクル生成の呼び出し(要トリガー)
			particleManagementCS.ParticleCreation(this.gameObject, (int)particleType, transform.position + new Vector3(0, 0, -1));

		}
	}
}
