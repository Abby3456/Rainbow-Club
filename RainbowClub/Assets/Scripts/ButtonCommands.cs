using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCommands : MonoBehaviour {

	int timesPressed = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void IveBeenPressed () {

		timesPressed++;

		Debug.Log ("Ive been Pressed" + timesPressed);

	}
}
