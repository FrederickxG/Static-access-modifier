using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            GameManager.playerScore += 10; //Increase the players's score
            Destroy(other.gameObject); //Destroy the collectible
        }
    }
}
