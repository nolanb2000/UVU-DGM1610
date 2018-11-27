// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class AmmoAmount : MonoBehaviour {
	
// 	public static int Ammo;

// 	Text AmmoText;


// 	// Use this for initialization
// 	void Start () {
// 		AmmoText = GetComponent<Text>();

// 		Ammo = 0;
		
// 	}
	
// 	// Update is called once per frame
// 	void Update () {
// 		if (Ammo < 0)
// 			Ammo = 0;
// 		AmmoText.text = "" + Amount;
// 	}

// 	public static void AddAmmo (int AddAmmo){
		
// 		Amount += AddAmmo;
// 	}
	
// }