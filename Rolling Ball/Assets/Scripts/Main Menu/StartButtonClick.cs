using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonClick : MonoBehaviour
{
  public void OnStartButtonClick()
  {
    SceneManager.LoadScene("Stage Select");
  }
}
