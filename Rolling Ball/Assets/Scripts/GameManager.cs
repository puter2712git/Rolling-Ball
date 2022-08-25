using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public static GameManager gameManager = null;

  public int mapIndex;
  public bool isFirst;
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

    isFirst = true;

    DontDestroyOnLoad(gameObject);
  }

  public void StageStart()
  {
    isPlayerDead = false;
    isPlaying = true;
    Time.timeScale = 1;
  }

  public void StageClear(int mapIndex)
  {
    if (isFirst)
    {
      PlayerPrefs.SetInt("Score", 0);
      isFirst = false;
    }

    if (PlayerPrefs.GetInt((mapIndex + 1).ToString()) == 0)
    {
      PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 2);
    }

    PlayerPrefs.SetInt((++mapIndex).ToString(), 1);
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
    SceneManager.LoadScene("Game Playing");
  }

  public void PauseGame()
  {
    isPlaying = false;
  }

  public void ResumeGame()
  {
    isPlaying = true;
  }
}
