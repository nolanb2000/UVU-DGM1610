using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Livesholder : MonoBehaviour {

	
	public static int Lives;

	Text LivesText;



	// Use this for initialization
	void Start () {
		LivesText = GetComponent<Text>();

		Lives = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Lives <= 0)
			Lives = 0;

	LivesText.text = "" + Lives;
	}


	public static void AddLives (int LivesToAdd){
		
		Lives -= LivesToAdd;
	}
	
}
