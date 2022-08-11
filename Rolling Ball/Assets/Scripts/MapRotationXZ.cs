using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotationXZ : MonoBehaviour
{
	private Camera _camera;

	private void Awake()
	{
		_camera = GameObject.Find("Main Camera").GetComponent<Camera>();
	}

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Vector3 mousePosition = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0f, -_camera.transform.position.z));
			Debug.Log(mousePosition);


			transform.LookAt(mousePosition);
			// transform.Rotate(Input.GetAxis("Mouse Y") * 0.5f, 0f, 0f);
		}
	}
}
