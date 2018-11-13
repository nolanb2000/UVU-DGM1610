using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;
	public GameObject Player;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;

	public int PointsForKill;

	public int TimeOut;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");

		EnemyDeath = Resources.Load("Prefab/Particle") as GameObject;

		ProjectileParticle = Resources.Load("Prefab/Particle") as GameObject;


		if(Player.transform.localScale.x < 0)
			Speed =-Speed;
		Destroy(gameObject, TimeOut);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag =="Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreHolder.AddPoints(PointsForKill);
		}

		Destroy (gameObject, 8);
	}

	void OnCollisionEnter2D(Collision2D other){
		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);	
	}
}
