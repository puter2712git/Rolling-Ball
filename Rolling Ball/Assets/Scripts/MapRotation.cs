using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotation : MonoBehaviour
{
  private float speed = 2f;

  private void Update()
  {
    if (Input.GetMouseButton(0))
    {
      transform.Rotate(0f, -Input.GetAxis("Mouse X") * speed, 0f);
      transform.Rotate(-Input.GetAxis("Mouse Y") * speed, 0f, 0f);
    }
  }
}
