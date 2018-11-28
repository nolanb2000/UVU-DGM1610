using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public LevelManager LevelManager;

	public int LivesToAdd;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.name =="Player"){
			LevelManager.RespawnPlayer();

		Livesholder.AddLives (LivesToAdd);
		}
	}
	
	

	// Update is called once per frame
	void Update () {
		
	}
}
