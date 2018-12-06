
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorMove : MonoBehaviour {
	//Player Movment Variables 
	public int MoveSpeed;
	public float JumpHeight;
	private bool DoubleJump;

	//player grounded variables 
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	//Non-Stick Player
	private float MoveVelocity;

	public Animator animator;

	// Use this for initialization
	void Start () {
		animator.SetBool("Iswalking", false);
		animator.SetBool("IsJumping", false);
		
	}

	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		
		//This Code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();

		}

		//Double Jump
		if(Grounded)
			DoubleJump = false;
			animator.SetBool("IsJumping", false);

		if(Input.GetKeyDown(KeyCode.Space)&& !DoubleJump && !Grounded){
			Jump();
			DoubleJump = true;
		}
		
		//Non-Stick Player
		MoveVelocity = 0f;
	

		//This lets your character move from side to side 
		if(Input.GetKey (KeyCode.D)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed,GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity = MoveSpeed;
			animator.SetBool("Iswalking", true);
			// animator.SetFloat("Speed", moveSpeed);
		}

		else if(Input.GetKeyUp(KeyCode.D)){
			animator.SetBool("Iswalking", false);
		}

		if(Input.GetKey (KeyCode.A)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity = -MoveSpeed;
			animator.SetBool("Iswalking", true);
		}
			else if(Input.GetKeyUp(KeyCode.A)){
			animator.SetBool("Iswalking", false);
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		if(GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(3f,3f,1f);

		else if(GetComponent<Rigidbody2D>().velocity.x < 0)
		transform.localScale = new Vector3(-3f,3,1f);

	}

	public void Jump(){
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
			animator.SetBool("IsJumping", true);
	}
}