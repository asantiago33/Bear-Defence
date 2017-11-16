using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NailGun : GunBaseClass {

	public float fireRate = 1f;

	private float timer;

	void Start() {
		timer = fireRate;
	}

	void Update() {
		timer -= Time.deltaTime;
		if (Input.GetKey(KeyCode.Space)) {
			if (timer <= 0f) {
				Fire ();
				timer = fireRate;
			}
		}
	}
		

	void Fire() {

		GameObject newbullet = null;

		newbullet = ObjectPoolNails.instance.GetPoolObject ();

		if (newbullet == null) {
			return;
		}

		newbullet.transform.SetPositionAndRotation (FirePosition.position, FirePosition.rotation);
		newbullet.SetActive (true);
		newbullet.GetComponent<Projectile> ().SetTarget (target);
	}
}
