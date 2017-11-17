using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSelectButton : MonoBehaviour {

	public void SimpleTurret() {
		BuildManager.instance.SelectSimpleTurret ();
	}

	public void Lazer() {
		BuildManager.instance.SelectLazer ();
	}

	public void Blaster() {
		BuildManager.instance.SelectBlaster ();
	}

	public void DTurret() {
		BuildManager.instance.SelectDTurret ();
	}
}
