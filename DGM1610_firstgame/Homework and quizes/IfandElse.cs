using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfandElse : MonoBehaviour {


	public string Candy; 

	// Use this for initialization
	void Start () {
	
		if (Candy == "Choclate");
			print("Give Them Sneakers");
		else if (Candy == "Gummy")
			print("Give Them GummyBears");
		else if (Candy == "Sweet")
			print("Give Them Lolipop");
		else 
			print ("They get Nothing!");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
