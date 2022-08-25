using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomButtonClick : MonoBehaviour
{
	public void OnRandomButtonClick()
	{
		if (PlayerPrefs.GetInt("Score") > 0)
		{
			PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 1);
		}
	}
}
