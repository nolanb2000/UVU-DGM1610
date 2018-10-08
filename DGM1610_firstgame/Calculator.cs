using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {

	public int Var1;
	public int Var2;
	public int Total;


	// Use this for initialization
	void Start () {
		Add(Var1,Var2);
		Sub(Var1,Var2)
		Div(Var1,Var2)
		Muil(Var1,Var2)

	}

	public void Add(int Var1, int Var2){
		Total = Var1 + Var1; 
		print(Total);
	}

	public void Sub(int Var1, int Var2){
		Total = Var1 - Var2;
		print(Total);
	}

	public void Div(int Var1, int Var2){
		Total = Var1 / Var2;
		print(Total);
	}

	public void Muil(int Var1, int Var2){
		Total = Var1 * Var2;
		print(Total;)
	}

	


	}




	
	// Update is called once per frame
	void Update () {
		
	}
}
