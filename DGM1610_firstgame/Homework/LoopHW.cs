using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopHW : MonoBehaviour {

	public int depth = -100;
	public int Water = 50;

	// Use this for initialization
	void Start () {
	 	for(int i=0; i >= 50; i++){
		
	 	print(i + "Marching");
	 	}

		 for(int p=0; p >= 150; p+10){

		print(p + "Points added ");
		}

		//for(){

		}

		while(depth <= 0){
			print("Going up " + depth);
			depth ++;
		}

		while(Water >= 0){
			print("Water Left "); 
			Water --;

		// }
		// while(){
			
		// }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
