using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialProcessing : MonoBehaviour
{
	public Image image;			//image
	public Material material;      //Material

	public float ElapsedTime;		//経過時間
	public float LimitTime = 10.0f;         //制限時間

	public bool canProcess;		//処理可能



	void Start()
    {
		material = image.material;      //マテリアルの取得
		ElapsedTime = 0.0f;             //経過時間の初期化
		canProcess = false;			//処理を不可に

		//ステータスチェック
		if (material.HasProperty("_KeyThreshold"))
		{
			Debug.Log("あるよ！");
			canProcess = true;		//処理を可能に
		}
	}

    // Update is called once per frame
    void Update()
    {
		if (canProcess)
		{
			ElapsedTime += Time.deltaTime;
			if (LimitTime >= ElapsedTime)
			{
				material.SetFloat("_KeyThreshold", 1.0f - ElapsedTime / LimitTime);
			}
			else
			{
				ElapsedTime = 0f;
			}
		}
	}
}
