using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Networking;

public class ParticleManagement : MonoBehaviour
{
	//Particleprefablist
	private GameObject[] particle = new GameObject[18];

	void Start()
	{
		particle[0] = Resources.Load<GameObject>("Effects/Particle_000");
		particle[1] = Resources.Load<GameObject>("Effects/Particle_001");
		particle[2] = Resources.Load<GameObject>("Effects/Particle_002");
		particle[3] = Resources.Load<GameObject>("Effects/Particle_003");
		particle[4] = Resources.Load<GameObject>("Effects/Particle_004");
		particle[5] = Resources.Load<GameObject>("Effects/Particle_005");
		particle[6] = Resources.Load<GameObject>("Effects/Particle_006");
		particle[7] = Resources.Load<GameObject>("Effects/Particle_007");
		particle[8] = Resources.Load<GameObject>("Effects/Particle_008");
		particle[9] = Resources.Load<GameObject>("Effects/Particle_009");
		particle[10] = Resources.Load<GameObject>("Effects/Particle_010");
		particle[11] = Resources.Load<GameObject>("Effects/Particle_011");
		particle[12] = Resources.Load<GameObject>("Effects/Particle_012");
		particle[13] = Resources.Load<GameObject>("Effects/Particle_013");
		particle[14] = Resources.Load<GameObject>("Effects/Particle_014");
		particle[15] = Resources.Load<GameObject>("Effects/Particle_015");
		particle[16] = Resources.Load<GameObject>("Effects/Particle_016");
		particle[17] = Resources.Load<GameObject>("Effects/Particle_017");
	}

	void Update()
	{
	}

	//Particleの生成
	//1:自身のオブジェクト
	//2:エフェクトのID
	//3:自身のオブジェクトの座標
	public void ParticleCreation(GameObject gameObject,int particleID, Vector3 objectPosition)
	{
		//呼び出し元オブジェクトの座標で指定IDのパーティクルを生成
		GameObject particleGameObject = Instantiate(particle[particleID], objectPosition, particle[particleID].transform.rotation);
        //呼び出し元をパーティクルの親に設定
		particleGameObject.transform.parent = gameObject.transform;
	}
}
