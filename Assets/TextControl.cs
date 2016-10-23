using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextControl : MonoBehaviour {

	public GameObject player;
	public Text info;
	public Player play = new Player();
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (play.getResult() == 1){
			info.text = "You lose";
		}
		if(play.getResult() == 2){
			info.text = "You win";
			Application.LoadLevel ("Scene2");
		}
	}
}
