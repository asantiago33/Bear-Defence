using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartNextRoundController : MonoBehaviour {
	public static StartNextRoundController instance = null;


	GameObject[] turrets;
	private Button button;

	void Start() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		button = gameObject.GetComponent<Button> ();
	}

	void Update() {
		if (NumberOfTurrets () <= 0) {
			button.interactable = false;
		} else {
			button.interactable = true;
		}
	}

	public int NumberOfTurrets() {
		turrets = GameObject.FindGameObjectsWithTag ("Turret");
		return turrets.Length;
	}
}
