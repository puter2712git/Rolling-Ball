using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class StageButtonClick : MonoBehaviour
{
  public void OnStageButtonClick() {
    GameObject clickedButton = EventSystem.current.currentSelectedGameObject;

    GameManager.gameManager.mapIndex = int.Parse(clickedButton.GetComponentInChildren<TextMeshProUGUI>().text) - 1;

    SceneManager.LoadScene("Game Playing");
    GameManager.gameManager.StageStart();
  }
}
