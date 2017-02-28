using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Craft : MonoBehaviour {

	public CanvasGroup canvasgroup;
	public CanvasGroup canvasgrouptools;
	public CanvasGroup canvasgroupweapons;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown ("b") && CircleMenu.WhichMenu == 0) {
			ShowOne ();
		}
		if (CircleMenu.WhichMenu == 1 && canvasgroup.alpha == 1f) {
			ShowTwo ();
		}
		if (CircleMenu.WhichMenu == 2 && canvasgroup.alpha == 1f) {
			ShowThree ();
		}
		if (Input.GetKeyUp ("b")) {
			Hide ();
			CircleMenu.WhichMenu = 0;
		}

	
	}

	void ShowOne() {

			canvasgroup.alpha = 1f;
			canvasgroup.blocksRaycasts = true;
		canvasgroup.interactable = true;


	}

	void ShowTwo() {

		canvasgrouptools.alpha = 1f;
		canvasgrouptools.blocksRaycasts = true;
		canvasgrouptools.interactable = true;
		canvasgroup.alpha = 0f;
		canvasgroup.blocksRaycasts = false;
		canvasgroup.interactable = false;
		canvasgroupweapons.alpha = 0f;
		canvasgroupweapons.blocksRaycasts = false;
		canvasgroupweapons.interactable = false;


	}

	void ShowThree() {

		canvasgrouptools.alpha = 0f;
		canvasgrouptools.blocksRaycasts = false;
		canvasgrouptools.interactable = false;
		canvasgroupweapons.alpha = 1f;
		canvasgroupweapons.blocksRaycasts = true;
		canvasgroupweapons.interactable = true;
		canvasgroup.alpha = 0f;
		canvasgroup.blocksRaycasts = false;
		canvasgroup.interactable = false;


	}


	void Hide () {

			canvasgroup.alpha = 0f;
			canvasgroup.blocksRaycasts = false;
		canvasgroup.interactable = false;
		canvasgrouptools.alpha = 0f;
		canvasgrouptools.blocksRaycasts = false;
		canvasgrouptools.interactable = false;
		canvasgroupweapons.alpha = 0f;
		canvasgroupweapons.blocksRaycasts = false;
		canvasgroupweapons.interactable = false;

	}
}
