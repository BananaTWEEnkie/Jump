using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {
	
	// Use this for initialization
	void Start ()
    {
        
    }
	
	void OnGUI()
	{
		const int buttonWidth = 128;
		const int buttonHeight = 60;

		// Draw a button to start the game
		if (GUI.Button(
		// Center in X, 2/3 of the height in Y
		new Rect(750, 375, buttonWidth, buttonHeight),"MENU"))
		{
			// On Click, load the first level.
			Application.LoadLevel("Menu");
		}
		
		if (GUI.Button(
		new Rect(750, 450, buttonWidth, buttonHeight),"RETRY"))
		{
			// On Click, load the main menu
			Application.LoadLevel("MainScene");
		}
		
		if (GUI.Button(new Rect(750, 525, buttonWidth, buttonHeight),"EXIT GAME"))
		{
			//print("Quitting Game...");
			Application.Quit();
		}
	}
    
}
