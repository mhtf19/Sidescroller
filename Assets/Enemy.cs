using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public int type = 0; //enemy type, 0 = red, 1 = blue, 2 = purple
	private Vector3 initPos;
	public float speed = 0f;
	public int direct = -1; //1 or -1
	public int dist = 10;

	void Start () {
		initPos = transform.position;
		if (speed == 0) {
			speed = 6;
		}
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		if (type == 0) {
			type0 ();
		}
		if (type == 1) {
			type1 ();
		}
		if (type == 2) {
			type2 ();
		}
	}

	void OnCollisionEnter(Collision hit){
		if (hit.collider.CompareTag ("Floor") || hit.collider.CompareTag ("Wall") || hit.collider.CompareTag("Enemy")) {
			direct = direct * -1;
		}
	}
	void type0(){
		if (Mathf.Abs (initPos.y - transform.position.y) > dist) {
			direct = -1*direct;
		}
		transform.Translate (0f, direct * speed * Time.deltaTime, 0f);
	}

	void type1(){
		if (Mathf.Abs (initPos.x - transform.position.x) > dist) {
			direct = -1*direct;
		}
		transform.Translate (direct * speed * Time.deltaTime, 0f, 0f);
	}
		
	void type2(){
		transform.Rotate (0, 0, 5);
		
	}
}
