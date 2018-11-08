using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {
	
	public string[] Animals; 

	// Use this for initialization
	void Start () {
		Animals = new string[5];

		Animals[0] ="Dog";
		Animals[1] ="Cat";
		Animals[2] ="Lizard";
		Animals[3] ="Rabbit";
		Animals[4] ="Hedgehog";

		foreach(string item in Animals){
			print("I Want a " + item);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
