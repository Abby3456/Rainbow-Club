using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour {

	public Sprite[] hover;

	//public Sprite [] updateIsReady;

	bool newUpdate = false;

	bool mouseOverIsTrue = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

//		if (mouseOverIsTrue == true) {
//			Debug.Log ("Over Button");
//		}

//		if (Input.GetKey (KeyCode.Space)) {
//			newUpdate = true;
//			transform.GetComponent<SpriteRenderer> ().sprite = updateIsReady [1];
//		} else {
//			newUpdate = false;
//			transform.GetComponent<SpriteRenderer> ().sprite = updateIsReady [0];
//		}
		
	}

	void OnMouseOver () {
		mouseOverIsTrue = true;

		transform.GetComponent<SpriteRenderer> ().sprite = hover [1];

		if (Input.GetMouseButton (0)) {
			transform.GetComponent<SpriteRenderer> ().sprite = hover [2];
		} else {
			transform.GetComponent<SpriteRenderer> ().sprite = hover [1];
		}

	}

	void OnMouseExit () {
		mouseOverIsTrue = false;

		transform.GetComponent<SpriteRenderer> ().sprite = hover [0];

	}

}
