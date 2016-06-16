using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class xEye3dHead : MonoBehaviour
{

	public Camera leftCamera;
	public Camera rightCamera;

	public float fov = 45;
	public float distanceFromCenter = 1;

	public bool cross = false;

	void Start ()
	{

	}

	void Update ()
	{

		leftCamera.transform.localPosition = (cross ? Vector3.right : -Vector3.right) * distanceFromCenter;
		rightCamera.transform.localPosition = (cross ? -Vector3.right : Vector3.right) * distanceFromCenter;



		leftCamera.fieldOfView = rightCamera.fieldOfView = fov;
	}
}
