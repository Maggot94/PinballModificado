using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleBumper : Bumper {

	private SpriteRenderer SpriteR;

	[SerializeField]
	private Color onColor;

	[SerializeField]
	private Color offColor;

	private BumperGroup BumperGroup;

	void Start () {

		SpriteR = GetComponent<SpriteRenderer> ();
		SpriteR.color = offColor;

	}


	public override void Colision ()
	{
		if (SpriteR.color == offColor) {
			BumperGroup.OneMoreIsOn ();
			SpriteR.color = onColor;

		} else {
			BumperGroup.OneMoreIsOff ();
			SpriteR.color = offColor;
		}
	}


	public void ReiniciarColor()
	{
		SpriteR.color = offColor;
	}


	public void SetBumperGroup(BumperGroup bg)
	{
		BumperGroup = bg;
	}


}
