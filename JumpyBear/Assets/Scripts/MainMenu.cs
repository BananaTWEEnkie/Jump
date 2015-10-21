using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

  void OnGUI()
  {
    const int buttonWidth = 128;
    const int buttonHeight = 60;

    // Draw a button to start the game
    if (GUI.Button(
      // Center in X, 2/3 of the height in Y
      new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight),
      "START"
      ))
    {
      // On Click, load the first level.
      Application.LoadLevel("MainScene"); // "Stage1" is the scene name
    }
  }
}