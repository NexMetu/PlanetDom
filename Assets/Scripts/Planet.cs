using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour {

	public int shipRate;
	public int totalShip = 0;
	Text text;
 

	// Use this for initialization
	void Start () {
		text = GetComponentInChildren<Text> ();
		if (text == null)
			Debug.Log ("not text field found");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void newTurn (){
		totalShip += shipRate;
		text.text = totalShip.ToString();
		Debug.Log (totalShip);


	}

}
