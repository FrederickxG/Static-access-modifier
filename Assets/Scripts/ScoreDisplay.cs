using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
 
public Text scoreText;

   private void Update()
   {
       // Update the displayed score with the value from the GameManager.
       scoreText.text = "Score" + GameManager.playerScore.ToString();
       }
}
