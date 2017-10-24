using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour {

	public int shipRate;
	public int totalShip = 0;
	//this planetstate is showing if the planet is either yours(0), netural(1) or an enemies (2)
	public int planetstate = 1;
	GameObject textfield;
	Canvas menu;
	GameObject button;
	bool selected;
 

	// Use this for initialization
	void Start () {
		menu= GetComponentInChildren<Canvas> ();
		menu.enabled = false;
		GameObject[] array = menu.GetComponentsInChildren<GameObject> ();
			
		text = GetComponentInChildren<Text> ();
		if (text == null)
			Debug.Log ("not text field found");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter() {
		if (!selected && planetstate == 0) {
			Debug.Log ("Mouse has entered");
			menu.enabled = true;
			menu.GetComponentInChildren<"MoveButton"> ();
		}
	}

	void OnMouseOver() {
		if (Input.GetMouseButtonDown (0) && planetstate == 0)
			selected = !selected;
		
	}

	void OnMouseExit(){
		if (!selected && planetstate == 0) {
			Debug.Log ("Mouse Exit");
			menu.enabled = false;
		}
	}

	public void newTurn (){
		selected = false;
		menu.enabled = false;
		totalShip += shipRate;
		text.text = totalShip.ToString();
		Debug.Log (totalShip);


	}

}

