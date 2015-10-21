 using UnityEngine;
 using System.Collections;
 
 public class Player : MonoBehaviour
 {
	 public float speed;
	 public float movespeed;
	 public int jumpHeight; //this is set in the Unity Inspector
     public bool isGrounded = false; //this can be seen working in the Unity inspector
     public Transform groundedEnd; //declares the empty game object in Unity acting as a collider set to the position of the player
	 
	 private Animator animator;
	 
	 void Start()
	 {
		 animator = GetComponent<Animator>();
	 }
 
	void FixedUpdate () 
     {
         Update (); //call the movement function below
         isGrounded = Physics2D.Linecast(this.transform.position, groundedEnd.position, 1 << LayerMask.NameToLayer("Ground")); 
         //the above line of code draws a linecast downwards to detect the ground game objects that have been placed in a ground layer
     }
 
     void Update ()
     {
         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.position += Vector3.left * speed * Time.deltaTime;
         }
		 
         if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.position += Vector3.right * speed * Time.deltaTime;
         }
		 
         if (Input.GetKey(KeyCode.Space) && isGrounded == true)
         {
			 // SoundEffectsHelper.Instance.MakeJumpSound();
			 animator.Play("jump");
			 GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpHeight);
         }
		 
		 else
		 {
			 animator.Play("idle");
		 }
     }
 }