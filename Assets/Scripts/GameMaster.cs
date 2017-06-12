using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	public int amountofplanets;
	public Transform planet;
	public Transform[] planetlist;
	// Use this for initialization
	void Start () {
//		planetlist = new GameObject[amountofplanets];
//		for(int x = 0; x < amountofplanets; x++){
//			planetlist [x] = Instantiate (planet);
//		}	
		
	}

	public void endTurn() {
		for (int x = 0; x < planetlist.Length; x++) {
			planetlist [x].GetComponent<Planet> ().newTurn ();
			Debug.Log (x);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
