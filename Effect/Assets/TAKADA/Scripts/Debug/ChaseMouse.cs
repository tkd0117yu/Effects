using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseMouse : MonoBehaviour
{
	Vector3 screenPoint;

	void Start()
    {
        
    }

    void Update()
    {
		this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 a = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		transform.position = Camera.main.ScreenToWorldPoint(a);
	}
}
