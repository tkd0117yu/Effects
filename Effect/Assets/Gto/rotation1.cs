using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation1 : MonoBehaviour
{
    public float rotationSpeed=0;
    public float StartSecond;
    public int StartSecondMax;
    // Start is called before the first frame update
    void Start()
    {
        StartSecond = 0;
        StartSecondMax = 1;
    }

    // Update is called once per frame
    void Update()
    {
        StartSecond += Time.deltaTime;
        Transform myTransform = this.transform;

        // ローカル座標基準で、現在の回転量へ加算する
        if(StartSecondMax<StartSecond)        myTransform.Rotate(0f,rotationSpeed,0f);
    }
}
