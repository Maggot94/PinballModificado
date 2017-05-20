using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Mal : MonoBehaviour {
	public AudioMixerSnapshot p;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Ball") {

			p.TransitionTo (1);
		}
	}
}

