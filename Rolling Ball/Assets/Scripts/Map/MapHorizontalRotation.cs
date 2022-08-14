using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapHorizontalRotation : MonoBehaviour
{
  private float _horizontalSpeed = 2f;

  private void Update()
  {
    if (Input.GetMouseButton(0))
    { 
      transform.Rotate(0f, -Input.GetAxis("Mouse X") * _horizontalSpeed, 0f);
    }
  }
}
