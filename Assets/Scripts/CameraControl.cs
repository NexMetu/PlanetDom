using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public float speed = 2f;

	public float sensitivity = 2f;

	bool atTopWall = false;
	bool atBtmWall = false;
	bool atRightWall = false;
	bool atLeftWall = false;

	// Use this for initialization
	void Start () {

	}

	void onTriggerEnter2D(Collider2D other) {
		if(other.tag == "LeftWall"){
			atLeftWall = true;
		} else if (other.tag == "RightWall"){
			atRightWall = true;
		} else if (other.tag == "TopWall"){
			atTopWall = true;
		}else if (other.tag == "BtmWall"){
			atBtmWall = true;
		}

	}

	void onTriggerExit2D(Collider2D other){
		if(other.tag == "LeftWall"){
			atLeftWall = false;
		} else if (other.tag == "RightWall"){
			atRightWall = false;
		} else if (other.tag == "TopWall"){
			atTopWall = false;
		}else if (other.tag == "BtmWall"){
			atBtmWall = false;
		}


	}

	void Update () {

		//Vector3 newPos = this.transform.position;
		//newPos.z += Input.GetAxis ("Mouse ScrollWheel") * sensitivity;
		//this.transform.position = newPos;


	}

	private void FixedUpdate()
	{

		// Basic camera movement //
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		if (atLeftWall && (moveHorizontal < 0)) {
			moveHorizontal = 0;
		}
		if (atRightWall && (moveHorizontal > 0)) {
			moveHorizontal = 0;
		}
		if (atTopWall && (moveVertical < 0)) {
			moveVertical = 0;
		}
		if (atLeftWall && (moveVertical > 0)) {
			moveVertical = 0;
		}

		if (!Input.GetMouseButton (1)) {
			transform.Translate (new Vector3 (speed * moveHorizontal, 0, 0));
		}

		transform.Translate (new Vector3 (0, speed * moveVertical, 0));


	}
}
