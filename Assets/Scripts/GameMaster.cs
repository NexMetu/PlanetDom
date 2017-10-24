using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

	public int amountofplanets;
	public Transform planet;
	public Transform[] planetlist;
	public Text text;
	public int noT = 1;
	public string turn = "Turn 1";
	// Use this for initialization
	void Start () {
		startTurn ();
		
	}
	public void startTurn(){
		text.CrossFadeAlpha(0f, 3f,false);
		planetlist [0].GetComponent<Planet> ().planetstate = 0;

	}

	public void move() {


	}

	public void endTurn() {
		text.enabled = true;
		noT++;
		turn = "Turn " + noT;
		text.text = turn;
		text.CrossFadeAlpha(255f, 0f,true);
		for (int x = 0; x < planetlist.Length; x++) {
			planetlist [x].GetComponent<Planet> ().newTurn ();
		}
		new WaitForSecondsRealtime (2);
		startTurn ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
