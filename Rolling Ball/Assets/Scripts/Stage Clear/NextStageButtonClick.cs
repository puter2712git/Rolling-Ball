using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class NextStageButtonClick : MonoBehaviour
{
	public void OnNextStageButtonClick()
	{
		GameObject clickedButton = EventSystem.current.currentSelectedGameObject;

		GameManager.gameManager.mapIndex++;

		SceneManager.LoadScene("Game Playing");
		GameManager.gameManager.StageStart();
	}
}
