using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour {

	public int shipRate;
	public int totalShip = 0;
	Text text;
	Canvas menu;
	bool selected;
 

	// Use this for initialization
	void Start () {
		menu= GetComponentInChildren<Canvas> ();
		menu.enabled = false;
		text = GetComponentInChildren<Text> ();
		if (text == null)
			Debug.Log ("not text field found");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter() {
		if (!selected) {
			Debug.Log ("Mouse has entered");
			menu.enabled = true;
		}
	}

	void OnMouseOver() {
		if (Input.GetMouseButtonDown (0))
			selected = !selected;
		
	}

	void OnMouseExit(){
		if (!selected) {
			Debug.Log ("Mouse Exit");
			menu.enabled = false;
		}
	}

	public void newTurn (){
		totalShip += shipRate;
		text.text = totalShip.ToString();
		Debug.Log (totalShip);


	}

}
