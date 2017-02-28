using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Building : MonoBehaviour {
	public int Hammerhold = 0;
	public GameObject Hammer;
	public SpriteRenderer HammerRender;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (WhichToolHeld.HammerSelect == 1) {
			HammerRender = Hammer.GetComponent<SpriteRenderer> ();
			HammerRender.enabled = true;
		}

		if (WhichToolHeld.HammerSelect == 0) {
			HammerRender = Hammer.GetComponent<SpriteRenderer> ();
			HammerRender.enabled = false;
		}

	}
}
