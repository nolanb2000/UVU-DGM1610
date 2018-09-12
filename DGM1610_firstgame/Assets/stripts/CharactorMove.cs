
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorMove : MonoBehaviour {
	//Player Movment Variables 
	public int MoveSpeed;
	public float JumpHeight;

	//player grounded variables 
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate () {
		Grounded = Physics2D.OverLapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		
		//This Code makes the character jump
		if(Input.GetKeyDown(KeyCode.Space)&& Grounded){
			Jump();
		}

		//This lets your character move from side to side 
		}

	public void Jump(){
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}