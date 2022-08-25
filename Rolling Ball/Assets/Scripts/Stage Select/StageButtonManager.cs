using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageButtonManager : MonoBehaviour
{
  private Button _myself;

  private void OnEnable()
  {
    _myself = GetComponent<Button>();

    if (PlayerPrefs.GetInt((int.Parse(gameObject.name) - 1).ToString()) == 1 || gameObject.name == "1")
    {
      _myself.interactable = true;
    }
  }
}
