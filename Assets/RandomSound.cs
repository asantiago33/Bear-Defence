using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour {

	public AudioClip[] clips;

	private AudioSource sound;

	void Awake()
	{
		sound = GetComponent<AudioSource>();
		int ran = Random.Range(0,13);
		sound.clip = clips[ran];
		sound.Play();
	}

	void OnCollisionEnter()
	{
		sound = GetComponent<AudioSource>();
		int ran = Random.Range(0,13);
		sound.clip = clips[ran];
		sound.Play();
	}
}
