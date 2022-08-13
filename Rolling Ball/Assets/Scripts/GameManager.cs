using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager gameManager = null;

  public int mapIndex;
  public bool isPlayerDead { private set; get;}

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

  public void PlayerDied()
  {
    isPlayerDead = true;
    StartCoroutine(PlayerDiedCoroutine());
  }

  IEnumerator PlayerDiedCoroutine()
  {
    yield return new WaitForSeconds(1.5f);
    isPlayerDead = false;
  }
}
