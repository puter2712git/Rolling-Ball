using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollide : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player") && !GameManager.gameManager.isPlayerDead) {
      Destroy(other.gameObject);
      GameManager.gameManager.PlayerDied();
    }
  }
}
