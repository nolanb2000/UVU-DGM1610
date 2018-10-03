using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player; 

	//Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle 

	//Respawn Delay
	public float RespawnDelay;

	//Penalty on Death 
	public int PointPenaltyOnDeath;

	//Store Gravity Value 
	private float GravityStore;

	// Use this for initialization
	void Start () {
		Player = FindObjectOfType<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RespawnPlayer(){
		StartCoroutine("RespawnPlayerCo")
	}

	public IEnumerator RespawnPlayerCo(){
		//Makes deathparticle 
		Instantiate (DeathParticle, Player.Transform.Position, Player.Transform.Rotation);
		//Hide player
		Player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		//Gravity Reset 
		GravityStore = Player.GetComponent<Rigidbody2D>().GravityScale;
		Player.GetComponent<Rigidbody2D().GravityScale = 0f; 
		Player.GetComponent<Rigidbody2D>().Velocity = Vector2.zero;
		//Score Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//Debug Message 
		Debug.Log("Player Respawn");
	}
}
