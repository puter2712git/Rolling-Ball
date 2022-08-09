using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager gameManager = null;

  private void Awake()
  {
    if (gameManager == null)
    {
      gameManager = this;
    }
    else if (gameManager != null)
    {
      Destroy(gameObject);
    }

    DontDestroyOnLoad(gameObject);
  }

  public void StageClear(string sceneName)
  {
    PlayerPrefs.SetInt(sceneName, 1);
  }
}
