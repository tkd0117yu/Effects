using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A100_EffectStatusController : MonoBehaviour
{ 
//コンポーネント保存用
public ParticleSystem particleSystem;
private ParticleSystem.MainModule particleSystemMain;
private ParticleSystem.EmissionModule particleSystemEmission;

//startLifetimeの量を変更]
/*
//噴射量設定用(コントローラー)
public float inputAmount;   //コントローラーの入力量
public const float baseInjectionAmount = 0.2f;          //基本噴射量
public const float additionalInjectionAmount = 0.05f;    //加算噴射量
public const float subtractInjectionAmount = 0.1f;      //減算噴射量
*/
//particleの色を変更
/*
//色リスト
public Color[] collarList = new Color[3]  {
	new Color(54f/255f, 83f/255f, 255f/255f,255f/255f),
	new Color(255f/255f, 255f/255f, 24f/255f,255f/255f),
	new Color(255f/255f, 50f/255f, 50f/255f,255f/255f) };
//噴射量リスト
public float[] rateList = new float[3] { 300.0f, 200.0f, 100.0f };
*/



void Start()
{
	//ParticleSystemコンポーネントからメインステータス部を抽出
	particleSystemMain = particleSystem.main;
	particleSystemEmission = particleSystem.emission;

	//色変更用
	/*
	collarList[0] = new Color(54f / 255f, 83f / 255f, 255f / 255f, 255f / 255f);
	collarList[1] = new Color(255f / 255f, 255f / 255f, 24f / 255f, 255f / 255f);
	collarList[2] = new Color(255f / 255f, 50f / 255f, 50f / 255f, 255f / 255f);
	*/
}

void Update()
{
	/*
	//コントローラー入力管理関数
	ControllerInputProcess();
	//particleの色を変更
	ChangeParticleColor();
	//噴出量を変更
	ChangeGushingQuantity();
	*/

	//スクリプト制御
	scriptControl();
}

//コントローラー入力管理
/*
void ControllerInputProcess()
{
	//入力量取得
	inputAmount = Input.GetAxis("Horizontal");

	//右入力
	if (0 < inputAmount)
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
*/
//particleの色を変更
/*
void ChangeParticleColor()
{
	if (Input.GetKeyDown(KeyCode.Alpha1))
	{
		particleSystemMain.startColor = collarList[0];
	}
	else if (Input.GetKeyDown(KeyCode.Alpha2))
	{
		particleSystemMain.startColor = collarList[1];
	}
	else if (Input.GetKeyDown(KeyCode.Alpha3))
	{
		particleSystemMain.startColor = collarList[2];
	}
}
*/
//噴出量を変更
/*
void ChangeGushingQuantity()
{
	if (Input.GetKeyDown(KeyCode.Alpha1))
	{
		particleSystemEmission.rateOverTime = rateList[0];
	}
	else if (Input.GetKeyDown(KeyCode.Alpha2))
	{
		particleSystemEmission.rateOverTime = rateList[1];
	}
	else if (Input.GetKeyDown(KeyCode.Alpha3))
	{
		particleSystemEmission.rateOverTime = rateList[2];
	}
}
*/

//スクリプト制御
void scriptControl()
{
	if (Input.GetKeyDown(KeyCode.Alpha4))
	{
		particleSystem.Play(true);
	}
	else if (Input.GetKeyDown(KeyCode.Alpha5))
	{
		particleSystem.Stop(true, ParticleSystemStopBehavior.StopEmitting);
	}
	else if (Input.GetKeyDown(KeyCode.Alpha6))
	{

	}

}

}