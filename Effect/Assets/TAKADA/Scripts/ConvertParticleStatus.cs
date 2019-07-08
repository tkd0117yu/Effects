using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertParticleStatus : MonoBehaviour
{
	//particleSystem
	public ParticleSystem particleSystem;

	//時間管理
	public float elapsedTime;               //経過時間
	public float delayTime = 0f;            //遅延時間
	public float executionTime = 0f;        //実行時間

	//実行処理内容
	//shape/Radius
	public bool shapeRadiusChange = false;
	public float sCDefaultValue;
	public float sCLastValue;

	//startSpeed
	public bool startSpeedChange = false;
	public float sSDefaultValue;
	public float sSLastValue;

	void Start()
	{
		particleSystem = GetComponent<ParticleSystem>();

		//変数初期化
		elapsedTime = 0.0f;     //経過時間
	}

	void Update()
	{
		//経過時間の加算
		elapsedTime -= Time.deltaTime;

		//時間経過処理の実行
		timeElapsedProcess();
	}

	//時間経過処理
	public void timeElapsedProcess()
	{
		//遅延時間の経過
		if (elapsedTime > delayTime)
		{
			//ここに追加したい処理を随時追加
			//shape/Radius
			if (shapeRadiusChange)
			{
				UnityEngine.ParticleSystem.ShapeModule shape = particleSystem.shape;
				shape.radius += (sCLastValue - sCDefaultValue) * (elapsedTime / executionTime);
			}

			//startSpeed
			if (shapeRadiusChange)
			{
				float startSpeed = particleSystem.startSpeed;
				startSpeed += (sCLastValue - sCDefaultValue) * (elapsedTime / executionTime);
				particleSystem.startSpeed = startSpeed;
			}
		}
	}
}
