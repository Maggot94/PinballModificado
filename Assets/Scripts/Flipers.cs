using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipers : MonoBehaviour {

	public GameObject LeftFlip;
	public GameObject RigthFlip; 

	private Rigidbody2D rbLeft; 
	private Rigidbody2D rbRigth;

	public Ball b;
	public float TorqueForce; 




	// Use this for initialization
	void Start () {

		rbLeft = LeftFlip.GetComponent<Rigidbody2D>();

		rbRigth = RigthFlip.GetComponent<Rigidbody2D>(); 
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z) && b.jugable == true ){

			AddTorque (rbLeft, TorqueForce);
	}
		if (Input.GetKeyDown (KeyCode.X) && b.jugable == true) {
			
			AddTorque (rbRigth, -TorqueForce); 
		}
}
	void AddTorque(Rigidbody2D rb, float force)
	{
		rb.AddTorque (force);

	}
}