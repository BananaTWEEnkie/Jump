using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void OnGUI()
  {
    const int buttonWidth = 128;
    const int buttonHeight = 60;

    // Draw a button to start the game
    if (GUI.Button(
      // Center in X, 2/3 of the height in Y
      new Rect(175, 525, buttonWidth, buttonHeight),
      "RETRY"
      ))
    {
      // On Click, load the first level.
      Application.LoadLevel("MainScene");
    }
  }
  

}
