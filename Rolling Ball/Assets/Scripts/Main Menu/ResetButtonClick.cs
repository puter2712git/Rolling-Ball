using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonClick : MonoBehaviour
{
	public void OnResetButtonClick()
	{
		PlayerPrefs.DeleteAll();
	}
}
