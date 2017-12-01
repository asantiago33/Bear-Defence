using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanelTransition : MonoBehaviour {

	public GameObject info1;
	public GameObject info2;
	public GameObject info3;

	private int counter = 0;
	public bool infoOff;


	void Start() {
		info2.SetActive (false);
		info3.SetActive (false);
	}

	void Update() {
		float charge = transform.GetComponent<Battery> ().currentCharge;
		if (Input.GetKeyDown(KeyCode.E)) {
			counter++;
		}
		if (counter == 1) {
			info1.SetActive (false);
			info2.SetActive (true);
		} else if (counter == 2 && !(charge > 20f) && !infoOff) {
			info2.SetActive (false);
		} else if (charge > 20 && !infoOff) {
			info3.SetActive (true);
		} 

		if (infoOff) {
			info3.SetActive (false);
			info2.SetActive (false);
			info1.SetActive (false);
		}


	}
}
