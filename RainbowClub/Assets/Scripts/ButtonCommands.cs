using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonCommands : MonoBehaviour {

	int timesPressed = 0;

	public GameObject infoPanel;

	public bool sethIsTrue = false;
	public bool thanhIsTrue = false;
	public bool kapIsTrue = false;
	public bool roseIsTrue = false;
	public bool meiIsTrue = false;

	public GameObject[] buttonObjects;

	public int[] inBetweenCount;

	public Text profileText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (sethIsTrue == true || thanhIsTrue == true || kapIsTrue == true || roseIsTrue == true || meiIsTrue == true) {
			infoPanel.gameObject.GetComponent<MeshRenderer> ().enabled = true;
		} else if (sethIsTrue == false && thanhIsTrue == false && kapIsTrue == false && roseIsTrue == false && meiIsTrue == false) {
			infoPanel.gameObject.GetComponent<MeshRenderer> ().enabled = false;
			profileText.text = "";
		}

	}

	public void IveBeenPressed () {

		timesPressed++;

		Debug.Log ("Ive been Pressed" + timesPressed);

	}

	public void OpenProfiles () {

//		if (sethIsTrue == true || thanhIsTrue == true || kapIsTrue == true || roseIsTrue == true || meiIsTrue == true) {
//			infoPanel.gameObject.GetComponent<MeshRenderer> ().enabled = true;
//		}
	}

	public void CloseProfiles () {

//		if (sethIsTrue == false && thanhIsTrue == false && kapIsTrue == false && roseIsTrue == false && meiIsTrue == false) {
//			infoPanel.gameObject.GetComponent<MeshRenderer> ().enabled = false;
//		}
	}

	public void SethIsTrue () {
		if (sethIsTrue == false) {
			sethIsTrue = true;
			thanhIsTrue = false;
			kapIsTrue = false;
			roseIsTrue = false;
			meiIsTrue = false;
			profileText.text = "Seth Russell-Khalil";
		} else if (sethIsTrue == true) {
			sethIsTrue = false;
		}
	}
	public void ThanhIsTrue () {
		if (thanhIsTrue == false) {
			thanhIsTrue = true;
			sethIsTrue = false;
			kapIsTrue = false;
			roseIsTrue = false;
			meiIsTrue = false;
			profileText.text = "Thanh Phan";
		} else if (thanhIsTrue == true) {
			thanhIsTrue = false;
		}
	}
	public void KapIsTrue () {
		if (kapIsTrue == false) {
			kapIsTrue = true;
			thanhIsTrue = false;
			sethIsTrue = false;
			roseIsTrue = false;
			meiIsTrue = false;
			profileText.text = "Kaptain Irving";
		} else if (kapIsTrue == true) {
			kapIsTrue = false;
		}
	}
	public void RoseIsTrue () {
		if (roseIsTrue == false) {
			roseIsTrue = true;
			thanhIsTrue = false;
			kapIsTrue = false;
			sethIsTrue = false;
			meiIsTrue = false;
			profileText.text = "Veronica Rose";
		} else if (roseIsTrue == true) {
			roseIsTrue = false;
		}
	}
	public void MeiIsTrue () {
		if (meiIsTrue == false) {
			meiIsTrue = true;
			thanhIsTrue = false;
			kapIsTrue = false;
			roseIsTrue = false;
			sethIsTrue = false;
			profileText.text = "Umeko Yukimura";
		} else if (meiIsTrue == true) {
			meiIsTrue = false;
		}
	}

//	public void ClosePanel () {
//		if (sethIsTrue == true) {
//		}
//	}
}
