using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectStatusController : MonoBehaviour
{
	//噴射量設定用(コントローラー)
	public float inputAmount;	//コントローラーの入力量
	public const float baseInjectionAmount = 0.2f;			//基本噴射量
	public const float additionalInjectionAmount = 0.05f;    //加算噴射量
	public const float subtractInjectionAmount = 0.1f;      //減算噴射量

	//コンポーネント保存用
	public ParticleSystem particleSystem;
	private ParticleSystem.MainModule particleSystemMain;
	
	void Start()
	{
		//ParticleSystemコンポーネントの取得
		//particleSystem = gameObject.GetComponent<ParticleSystem>();
		//ParticleSystemコンポーネントからメインステータス部を抽出
		particleSystemMain = particleSystem.main;
	}

	void Update()
	{
		//コントローラー入力管理関数
		ControllerInputProcess();
	}

	//コントローラー入力管理
	void ControllerInputProcess()
	{
		//入力量取得
		inputAmount = Input.GetAxis("Horizontal");

		//右入力
		if(0 < inputAmount)
		{
			//噴射量の変更(基本噴射量 + 加算用噴射量 * 入力割合)
			particleSystemMain.startLifetime = baseInjectionAmount + additionalInjectionAmount * inputAmount;
		}
		//左入力
		else if (inputAmount < 0)
		{
			//噴射量の変更(基本噴射量 + 減算用噴射量 * 入力割合)
			particleSystemMain.startLifetime = baseInjectionAmount + subtractInjectionAmount * inputAmount;
		}
	}


}
