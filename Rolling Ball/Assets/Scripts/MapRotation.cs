using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotation : MonoBehaviour
{
  private float _horizontalSpeed = 2f;
  private float _verticalSpeed = 0.5f;

  private void Update()
  {
    if (Input.GetMouseButton(0)) {
      transform.Rotate(0f, -Input.GetAxis("Mouse X") * _horizontalSpeed, 0f);
      transform.Rotate(-Input.GetAxis("Mouse Y") * _verticalSpeed, 0f, 0f);
    }
  }
}
