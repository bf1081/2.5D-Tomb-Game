using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Craft : MonoBehaviour {

	public CanvasGroup canvasgroup;
	public CanvasGroup canvasgrouptools;
	public CanvasGroup canvasgroupweapons;
	public CanvasGroup canvasgroupbuilding;
	public CanvasGroup HasHammer;
	public CanvasGroup HasAxe;
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
		if (CircleMenu.WhichMenu == 3 && canvasgroup.alpha == 1f) {
			ShowFour ();
		}
		if (Input.GetKeyUp ("b") && canvasgroupbuilding.alpha == 0f) {
			Hide ();
			CircleMenu.WhichMenu = 0;
		}

		if (Input.GetKeyUp ("f")) {
			Hide2 ();
			CircleMenu.WhichMenu = 0;
		}

		if (CraftingPercent.HasHammer == 1) {
			HasHammer.alpha = 1f;
			HasHammer.blocksRaycasts = true;
			HasHammer.interactable = true;
		}
		if (CraftingPercent.HasAxe == 1) {
			HasAxe.alpha = 1f;
			HasAxe.blocksRaycasts = true;
			HasAxe.interactable = true;
		}
	
	}

	void ShowOne() {

			canvasgroup.alpha = 1f;
			canvasgroup.blocksRaycasts = true;
		canvasgroup.interactable = true;
		canvasgroupbuilding.alpha = 0f;
		canvasgroupbuilding.blocksRaycasts = false;
		canvasgroupbuilding.interactable = false;


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
		canvasgroupbuilding.alpha = 0f;
		canvasgroupbuilding.blocksRaycasts = false;
		canvasgroupbuilding.interactable = false;


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
		canvasgroupbuilding.alpha = 0f;
		canvasgroupbuilding.blocksRaycasts = false;
		canvasgroupbuilding.interactable = false;


	}
	void ShowFour() {

		canvasgrouptools.alpha = 0f;
		canvasgrouptools.blocksRaycasts = false;
		canvasgrouptools.interactable = false;
		canvasgroupweapons.alpha = 0f;
		canvasgroupweapons.blocksRaycasts = false;
		canvasgroupweapons.interactable = false;
		canvasgroup.alpha = 0f;
		canvasgroup.blocksRaycasts = false;
		canvasgroup.interactable = false;
		canvasgroupbuilding.alpha = 1f;
		canvasgroupbuilding.blocksRaycasts = true;
		canvasgroupbuilding.interactable = true;


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
	void Hide2 () {
		canvasgroupbuilding.alpha = 0f;
		canvasgroupbuilding.blocksRaycasts = false;
		canvasgroupbuilding.interactable = false;
	}
}
