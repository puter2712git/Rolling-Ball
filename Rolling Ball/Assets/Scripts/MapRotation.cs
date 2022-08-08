using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotation : MonoBehaviour
{
  private float _horizontalSpeed = 2f;
  private float _verticalSpeed = 0.5f;

  public GameObject dRotate;
  public GameObject aRotate;

  private void Update()
  {
    if (Input.GetKey(KeyCode.D)) {
      transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dRotate.transform.position), Time.deltaTime * _verticalSpeed);
    }
  }
}
