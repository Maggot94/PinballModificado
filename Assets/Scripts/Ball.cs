using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SgLib;
public class Ball : MonoBehaviour {


	public bool Death = false; 
	public GameObject ballprefab;
	public GameObject BallSpawnPoint;
	public int vidas = 7;
	public bool jugable = true;
	public GameObject GameOver; 
	public Text Score;
	public int VidaExtra = 2000;
	
	// Use this for initialization
	void Start () {

		SetScoreText (); 
	}
	
	// Update is called once per frame
	void Update () {

		if (ScoreManager.Instance.Score == VidaExtra) {
			vidas++; 
			VidaExtra = VidaExtra + 2000;
		}

		if (vidas <= 0) {
			Debug.Log (Death); 


			Death = false; 
			jugable = false;
			GameOver.SetActive(true); 


		}

		if (Death == true && jugable == true) {
			
		
			BallSpawn (); 

		}

	

	}



	void OnTriggerEnter2D (Collider2D Other){
		
		if (Other.gameObject.tag == "Ball") {

			Death = true; 
			Destroy (Other.gameObject); 
		}
	}
	 void BallSpawn () {


		GameObject ball = Instantiate (ballprefab, BallSpawnPoint.transform.position, Quaternion.identity) as GameObject;
		vidas--;
		Death = false;

	}


	public void SetScoreText ()
	{
		Score.text = "Score: " + ScoreManager.Instance.Score.ToString ();
	}



}
