using UnityEngine;
using System.Collections;

public class BalloonAnimeScript : MonoBehaviour {

	public float speed;
	 public float movespeed;
	 public int jumpHeight; //this is set in the Unity Inspector
     public bool isGrounded; //this can be seen working in the Unity inspector
     public Transform groundedEnd; //declares the empty game object in Unity acting as a collider set to the position of the player

	// Use this for initialization
	void Start () {
	
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpHeight);
	}
         
         void OnCollisionStay(Collision coll){
                isGrounded = true;
              }
         void OnCollisionExit(Collision coll){
                if(isGrounded){
                   isGrounded = false;   
                }
         }
	
	// Update is called once per frame
	void Update () {
		
		if (isGrounded == true)
         {
			 GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpHeight);
         }
		
	}
	
}
