using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonClick : MonoBehaviour
{
  public void OnBackButtonClick() {
    SceneManager.LoadScene("Main Menu");
  }
}
