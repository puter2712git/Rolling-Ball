using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalEnter : MonoBehaviour
{
  public Slider goalProgressSlider;

  private void OnTriggerStay(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      goalProgressSlider.value += 1 / Time.timeScale;
    }
  }

  private void Update()
  {
    if (goalProgressSlider.value == 100 && GameManager.gameManager.isPlaying)
    {
      GameManager.gameManager.StageClear(SceneManager.GetActiveScene().name);
    }
  }
}
