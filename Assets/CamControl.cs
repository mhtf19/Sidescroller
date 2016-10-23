using UnityEngine;
using System.Collections;

public class CamControl : MonoBehaviour {
	
	private Vector3 dist;
	public GameObject player;
	// Use this for initialization
	void Start () {
		dist = transform.position - player.transform.position;

	}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + dist;
	}
}
