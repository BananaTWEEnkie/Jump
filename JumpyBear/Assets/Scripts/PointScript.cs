using UnityEngine;
using System.Collections;

public class PointScript : MonoBehaviour {

    public int scoreValue;
    private GameController gameController;

    void Start ()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent <GameController>();
        }
        if (gameController == null)
        {
            Debug.Log ("Cannot find 'GameController' script");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Collision with flowers
        FlowerScript flowers = collision.gameObject.GetComponent<FlowerScript>();
        if (flowers != null)
        {
            //SoundEffectsHelper.Instance.MakeCatchSound();
            //gameController.AddScore (scoreValue);
            Destroy(flowers.gameObject);
        }
		
		// Collision with hot air balloon causes game to end
		BalloonScript balloon = collision.gameObject.GetComponent<BalloonScript>();
        if (balloon != null)
        {
            Application.LoadLevel("WinnerScene");
        }
    }

}
