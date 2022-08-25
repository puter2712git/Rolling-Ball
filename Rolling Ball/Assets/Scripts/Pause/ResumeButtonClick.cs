using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResumeButtonClick : MonoBehaviour
{
	public void OnResumeButtonClick()
	{
		GameObject pauseMenu = EventSystem.current.currentSelectedGameObject;
		Time.timeScale = 1;
		GameManager.gameManager.ResumeGame();
		pauseMenu.transform.root.gameObject.SetActive(false);
	}
}
