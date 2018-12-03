using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {
	
	public string[] Animals; 
	public string[] Weapons;
	public string[] Monsters;


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


		Weapons = new string[5];

		Weapons[0] ="Sword";
		Weapons[1] ="Bow";
		Weapons[2] ="Axe";
		Weapons[3] ="Dagger";
		Weapons[4] ="GreatSword";

		foreach(string item in Weapons){
			print("Would you like tom buy a " + item);
		}

		Monsters = new string[5];

		Monsters[0] ="Werewolf";
		Monsters[1] ="Dragons";
		Monsters[2] ="Wraith";
		Monsters[3] ="Goblin";
		Monsters[4] ="Wyvern";

		foreach(string item in Monsters){
			print("You must Hunt Down a " + item);
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
