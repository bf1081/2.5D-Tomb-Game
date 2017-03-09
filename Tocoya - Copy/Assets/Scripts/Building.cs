using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Building : MonoBehaviour {
	public static int Hammerhold = 0;
	public GameObject Hammer;
	public SpriteRenderer HammerRender;
	public int Axehold = 0;
	public GameObject Axe;
	public SpriteRenderer AxeRender;
	public SpriteRenderer block1render;
	public GameObject block1;
	public GameObject block;
	public GameObject tallblock;
	public GameObject tallblock1;
	public SpriteRenderer tallblock1render;
	 float rotatetallblock;
	public CanvasGroup canvas;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (WhichToolHeld.HammerSelect == 1) {
			HammerRender = Hammer.GetComponent<SpriteRenderer> ();
			HammerRender.enabled = true;
			Hammerhold = 1;
		}

		rotatetallblock = Input.GetAxis ("Mouse ScrollWheel");

		if (HammerRender.enabled == true && Input.GetButtonDown("Fire2")) {
			CircleMenu.WhichMenu = 3;
		}

		if (CircleMenu.WhichBlock == 2) {
			block1render = block1.GetComponent<SpriteRenderer> ();
			block1render.enabled = true;
			tallblock1render = tallblock1.GetComponent<SpriteRenderer> ();
			tallblock1render.enabled = false;

		}
		if (CircleMenu.WhichBlock == 1) {
			tallblock1render = tallblock1.GetComponent<SpriteRenderer> ();
			tallblock1render.enabled = true;
			block1render = block1.GetComponent<SpriteRenderer> ();
			block1render.enabled = false;

		}


		tallblock1.transform.Rotate (Vector3.forward, rotatetallblock * 20);


		if (ScoreManager.wood >= 20 && Hammerhold == 1 && Input.GetButtonDown("Fire1") && CircleMenu.WhichBlock == 2 && canvas.alpha == 0f) {
			Instantiate (block, block1.transform.position, block1.transform.rotation);
			ScoreManager.wood = ScoreManager.wood - 20;
				
		}

		if (ScoreManager.wood >= 60 && Hammerhold == 1 && Input.GetButtonDown("Fire1") && CircleMenu.WhichBlock == 1 && canvas.alpha == 0f) {
			Instantiate (tallblock, tallblock1.transform.position, tallblock1.transform.rotation);
			ScoreManager.wood = ScoreManager.wood - 60;

		}


		if (WhichToolHeld.HammerSelect == 0) {
			HammerRender = Hammer.GetComponent<SpriteRenderer> ();
			HammerRender.enabled = false;
			block1render = block1.GetComponent<SpriteRenderer> ();
			block1render.enabled = false;
			tallblock1render = tallblock1.GetComponent<SpriteRenderer> ();
			tallblock1render.enabled = false;
			Hammerhold = 0;
		}

	}
}
