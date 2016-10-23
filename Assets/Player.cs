using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public float speed = 0;
	private float airTime = 0;
	private int result = 0;
	private Vector3 pPos;

	void Start () {
		pPos = transform.position;
		if (speed == 0) {
			speed = 8;
		}

	}

	void FixedUpdate () {
		
		if (airTime > 15) {
			transform.Translate(speed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
		} else {
			transform.Translate (speed * Time.deltaTime * Input.GetAxis ("Horizontal"), speed * Time.deltaTime * Input.GetAxis ("Vertical"), 0);
			if (Input.GetAxis ("Vertical") == 1) {
				airTime= airTime+.5f;
			}
		}
	}

	void OnCollisionEnter(Collision hit){ 
		if (hit.collider.CompareTag("Enemy")) {
			loss ();
		}
		if (hit.collider.CompareTag ("Floor")) {
			airTime = 0f;
		}
		if(hit.collider.CompareTag("Goal")){
			win ();
		}
		if(hit.collider.CompareTag("SpeedPU") && speed < 22){
			speed = speed + 3;
			print (speed);
		}

	}

	void loss(){
		print ("You Lose");
		result = 1;
		transform.position = pPos;
	}

	void win(){
		print ("You Win!!");
		result = 2;
	}
	public int getResult(){
		return result;
	}
}
