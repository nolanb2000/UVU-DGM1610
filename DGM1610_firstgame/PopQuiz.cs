using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopQuiz : MonoBehaviour {


//Int Holder 
//and define public or private
public int Variable1;
public int Variable2; 
public int Total;


void Start(){
	CalcAdd();
}
//Didnt Add this part 
public void Calc(){

	Add(Variable1,Variable2)
 }

//Adds the two Variables and prints it 
 public void Add( int Variable1 , int Variable2){
	//Tells what Total is 
	Total = Variable1 + Variable2;
	//prints the Total 
	Print (Total); 
	
}


}
