using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanelTransition : MonoBehaviour {

	public GameObject info1;
	public GameObject info2;

	private int counter = 0;

	void Start() {
		info2.SetActive (false);
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.E)) {
			counter++;
		}
		if (counter == 1) {
			info1.SetActive (false);
			info2.SetActive (true);
		} else if (counter >= 2) {
			info2.SetActive (false);
		}
	}
}
