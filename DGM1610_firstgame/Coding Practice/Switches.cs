using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	// public int num; 
	public string name;


	// Use this for initialization
	void Start () {
		
		// if(num == 1){
		// 	print("You Picked one");
		// }

		// else if( num== 2){

		// }

		// else if(num== 3){
			
		// }

		// else{
		// 	print("You did not pick one");

		// }

		// switch(num){

		// 	case 1:
		// 		print("You picked" + num );
		// 	break;
			
		// 	case 3:
		// 		print("You picked" + num );
		// 	break;
			
		// 	case 6:
		// 		print("You picked" + num );
		// 	break;
			
		// 	case 10:
		// 		print("You picked" + num );
		// 	break;

		// 	default:
		// 		print("Whatttttt" + num);
		// 	break;
		// }

		switch(name){
			case "Jason":
				print("Welcome to camp" + name + "- Love Mother");
			break;

			case "Michael":
				print("Welcome to Haddonfield" + name);
			break;

			case "Freddie":
				print("Welcome to Elm Street" + name);
			break;

			case "Leatherface":
				print("The stars and stripes are big at night...Deep in the heart of Texas" + name);
			break;

			default:
				print("I Dont know you" + name);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
