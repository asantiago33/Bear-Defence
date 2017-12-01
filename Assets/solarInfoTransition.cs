using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solarInfoTransition : MonoBehaviour {

	private bool transition;
	public GameObject info1;

	void Update() {
		if (transition) {
			info1.SetActive (false);
		}
	}

	public void Trns() {
		transition = true;
	}
}
