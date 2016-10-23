using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
	
	void Update () {
		transform.Rotate (0f, 0f, 10);
	}

	void OnCollisionEnter(Collision hit){
		if (hit.collider.CompareTag ("Player")) {
			print ("Don't stop!");
		}
	}
}
