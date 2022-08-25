using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectButtonClick : MonoBehaviour
{
	public void OnStageSelectButtonClick()
	{
		SceneManager.LoadScene("Stage Select");
	}
}
