using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickUP : MonoBehaviour {

	public int PointsToAdd;

	void OnTriggerEnter2D (Collider2D Other){
		if(Other.GetComponent<Rigidbody2D> () == null)
			return;

		ScoreHolder.AddPoints (PointsToAdd);

		Destroy (gameObject);
	}

}
