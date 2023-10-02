using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {
//Attach this script to the Target

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Rock") {
			Debug.Log ("Target Hit");	
			ScoreCount.gscore += 1; //add score
            Destroy(gameObject);
		}

	}
}
