using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public static GameManager gameManager = null;

  public int mapIndex;
  public bool isPlayerDead { private set; get; }
  public bool isPlaying { private set; get; }

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

  public void StageStart()
  {
    isPlayerDead = false;
    isPlaying = true;
  }

  public void StageClear(string sceneName)
  {
    PlayerPrefs.SetInt(sceneName, 1);
    isPlaying = false;
    StartCoroutine(StageClearCoroutine());
  }

  IEnumerator StageClearCoroutine()
  {
    yield return new WaitForSeconds(1.5f);
    SceneManager.LoadScene("Stage Clear");
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
