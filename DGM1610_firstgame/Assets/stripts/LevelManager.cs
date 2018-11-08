using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Player; 
	public GameObject Player2;

	//Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//Penalty on Death 
	public int PointPenaltyOnDeath;

	//Store Gravity Value 
	private float GravityStore;

	// Use this for initialization
	void Update () {
		
	}
	
	// Update is called once per frame
	void Start () {
		//Player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Makes deathparticle 
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Hide player
		//Player.enabled = false;
		Player2.SetActive(false);
		Player.GetComponent<Renderer> ().enabled = false;
		//Gravity Reset 
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f; 
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Score Penalty
		ScoreHolder.AddPoints(-PointPenaltyOnDeath);
		//Debug Message 
		Debug.Log("Player Respawn");
		//Respwan Delay 
		yield return new WaitForSeconds (RespawnDelay);
		//Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//Players Transform Position 
		Player.transform.position = CurrentCheckPoint.transform.position;
		//Show Player
		//player. enable = true;
		Player2.SetActive(true);
		Player.GetComponent<Renderer> ().enabled = true;
		//Spawn Player 
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);

	}
}
