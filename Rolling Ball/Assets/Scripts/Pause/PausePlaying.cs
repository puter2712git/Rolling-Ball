using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePlaying : MonoBehaviour
{
	public Canvas pauseMenu;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Time.timeScale = Time.timeScale == 0 ? 1 : 0;
			if (pauseMenu.gameObject.activeSelf)
			{
				pauseMenu.gameObject.SetActive(false);
				GameManager.gameManager.ResumeGame();
			}
			else if(!pauseMenu.gameObject.activeSelf)
			{
				pauseMenu.gameObject.SetActive(true);
				GameManager.gameManager.PauseGame();
			}
		}
	}
}
