using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPickBackButtonClick : MonoBehaviour
{
	public void OnBackButtonClick()
	{
		SceneManager.LoadScene("Main Menu");
	}
}
