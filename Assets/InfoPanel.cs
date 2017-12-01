using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour {


	public float baseSize = 1f;

	void Update () {
		transform.rotation = Quaternion.identity;
		float anim = baseSize + Mathf.Sin(Time.time * 5f) * baseSize / 7f;
		transform.localScale = Vector3.one * anim;
	}
}
