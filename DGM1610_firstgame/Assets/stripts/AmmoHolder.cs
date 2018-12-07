using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoHolder : MonoBehaviour {

	public static int Ammo; 
	public int MaxAmmo;
	public Text AmmoText;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();

		Ammo = 15;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	AmmoText.text = "" + Ammo;

	}

	public static void ChangeAmmo (int AmmoToAdd){
		
		Ammo += AmmoToAdd;
	}
}
