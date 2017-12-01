using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSelectController : MonoBehaviour {

	private Sprite regularSprite;
	public Sprite selectedSprite;
	public bool isHighlighted;
	public bool hasBuilding;
	public GameObject info;

	private SpriteRenderer sr;

	void Start() {
		sr = GetComponent<SpriteRenderer> ();
		regularSprite = sr.sprite;
	}

	void OnMouseEnter() {
		sr.sprite = selectedSprite;
		BuildManager.instance.SetTile (transform);
		InfoOn ();
	}

	void OnMouseExit() {
		sr.sprite = regularSprite;
		BuildManager.instance.SetTile (null);
		InfoOff();
	}

	void InfoOn() {
		int num = StartNextRoundController.instance.NumberOfTurrets ();
		if (isHighlighted && num <= 0) {
			info.SetActive (true);
			info.transform.SetPositionAndRotation (transform.position + new Vector3(0f, 2f, 0f), transform.rotation);
		}
	}

	void InfoOff() {
		info.SetActive (false);
	}
		
		
}
