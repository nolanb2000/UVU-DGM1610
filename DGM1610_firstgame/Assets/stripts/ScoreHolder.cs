﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreHolder : MonoBehaviour {

	
	public static int Score;
	public int WinScore;

	Text ScoreText;

	public Text WinText;

	void Awake(){ 
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {
		ScoreText = GetComponent<Text>();

		Score = 0;

		WinText.GetComponent<Text>().enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0)
			Score = 0;
		ScoreText.text = "" + Score;
		
		if(Score>= WinScore ){
			print("Win Reached =" + Score);
			WinText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}
	}

	public static void AddPoints (int PointsToAdd){
		
		Score += PointsToAdd;
	}
	
}
