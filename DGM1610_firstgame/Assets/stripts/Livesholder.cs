using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Livesholder : MonoBehaviour {

	
	public static int Lives;

	Text LivesText;
	public Text GameOver;

	// Use this for initialization
	void Start () {
		LivesText = GetComponent<Text>();

		Lives = 3;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	LivesText.text = "" + Lives;

	if(Lives<= 0 ){
			print("GameOver");
			GameOver.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
	}


	}

	public static void AddLives (int LivesToAdd){
		
		Lives -= LivesToAdd;
	}
	
}
