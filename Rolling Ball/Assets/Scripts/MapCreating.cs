using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreating : MonoBehaviour
{
  public GameObject[] maps = new GameObject[32];

  private void OnEnable()
  {
    Instantiate(maps[GameManager.gameManager.mapIndex]);
  }
}
