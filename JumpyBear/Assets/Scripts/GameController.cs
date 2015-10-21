using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
/*
    public GUIText scoreText;
    //private int score;

    void Start ()
    {
        //score = 0;
        //Update ();
    }

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore ();
    }


	private float timeLeft = 30.0f;
     
     void Update()
     {	 
		 scoreText.text = timeLeft;
         timeLeft -= Time.deltaTime;
         if(timeLeft < 0)
         {
             Application.LoadLevel("GameOver");
         }
     }*/
	 
	 float timeRemaining = 30.0f;

    void Update () {
        timeRemaining -= Time.deltaTime;
    }
    
    void OnGUI(){
        if(timeRemaining > 0){
            GUI.Label(new Rect(15, 20, 200, 100), 
                         ""+ timeRemaining);
        }
        else{
            Application.LoadLevel("GameOver");
        }
	}

/*


    void UpdateScore ()
    {
        scoreText.text = "Score: " + score;
    }*/
}