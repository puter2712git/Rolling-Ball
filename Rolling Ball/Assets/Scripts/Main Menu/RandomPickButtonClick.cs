using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPickButtonClick : MonoBehaviour
{
	public void OnRandomPickButtonClick()
	{
		SceneManager.LoadScene("Random Pick");
	}
}
