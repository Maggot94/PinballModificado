using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SgLib;

public class Bumper : MonoBehaviour {

	[SerializeField]
	private float applyForce;
	public int Amount = 500; 
	public Ball b; 

	// Use this for initialization
	void Start () {



	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Vector3 direction = (other.transform.position - transform.position).normalized;

		AddFroceToOther (other, direction);
		Colision ();
	}

	void AddFroceToOther (Collision2D other, Vector3 direction)
	{
		ScoreManager.Instance.AddScore (Amount);
		b.SetScoreText ();

		other.gameObject.GetComponent<Rigidbody2D> ().AddForce (direction * applyForce);
	}

	public virtual void Colision ()
	{



	}


	// Update is called once per frame
	void Update () {

	}
}
