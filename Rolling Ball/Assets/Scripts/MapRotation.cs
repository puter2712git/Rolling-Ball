using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotation : MonoBehaviour
{
  private GameObject _xzRotation;
  private float _horizontalSpeed = 2f;
  private float _verticalSpeed = 0.5f;

  private void Awake()
  {
    _xzRotation = transform.Find("XZ Rotation").gameObject;
  }

  private void Update()
  {
    if (Input.GetMouseButton(0))
    { 
      transform.Rotate(0f, -Input.GetAxis("Mouse X") * _horizontalSpeed, 0f);
    }
  }

  // private void LateUpdate() 
  // {
  //   transform.rotation = Quaternion.Euler(_xzRotation.transform.rotation.x, this.transform.rotation.y, _xzRotation.transform.rotation.z);
  // }
}
