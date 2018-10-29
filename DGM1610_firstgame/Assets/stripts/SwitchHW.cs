using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchHW : MonoBehaviour {

	public string quest; 

	// Use this for initialization
	void Start () {


	switch(quest){

		case "Hunt Quests":
			print("We Have " + quest + " One out for a Gang of Goblins causing trouble");
		break;

		case "Save Quests":
			print("We Have " + quest + " One of the local towns has put out a reward for a missing mother");
		break;

		case "Special Quest":
			print("We have one " + quest + " The king has made a contract for a local Wyvern causing trouble near here");
		break;

		default:
			print("We have no " + quest + " At This time");
		break; 

	

	}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
