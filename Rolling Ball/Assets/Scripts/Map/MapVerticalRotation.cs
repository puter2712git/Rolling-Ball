using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapVerticalRotation : MonoBehaviour
{
  private float _verticalSpeed = 0.1f;

  private void Update()
  {
    if (Input.GetKey(KeyCode.W))
    {
      transform.Rotate(_verticalSpeed, 0f, 0f);
    }
    if (Input.GetKey(KeyCode.S))
    {
      transform.Rotate(-_verticalSpeed, 0f, 0f);
    }
    if (Input.GetKey(KeyCode.A))
    {
      transform.Rotate(0f, _verticalSpeed, 0f);
    }
    if (Input.GetKey(KeyCode.D))
    {
      transform.Rotate(0f, -_verticalSpeed, 0f);
    }
  }
}
