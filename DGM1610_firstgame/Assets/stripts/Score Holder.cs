using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public static int Score;

	Text ScoreText;

public class ScoreHolder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ScoreText = GetComponent<Text>();

		Score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0)
			Score = 0;
		ScoreText.Text = "" + Score;
	}

	public static void AddPoints (int PointsToAdd){
		Score += PointsToAdd;
	}



		
	
}
