using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public static CameraController instance = null;
	public GameObject Grid;

	private bool hasCameraAligned = false;

	void Awake()
	{

		if (instance == null)
			instance = this;
		else
			Destroy(gameObject);
	}

	//adjusts camera height upon increasing grid size
	public void RealignCamera()
	{
		if (!hasCameraAligned)
		{
			gameObject.transform.position += new Vector3(40,30, -60);
			hasCameraAligned = true;
		}
		;

	}
}
