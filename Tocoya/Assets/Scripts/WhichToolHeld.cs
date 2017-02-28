using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WhichToolHeld : MonoBehaviour {
	public GameObject HammerSelectBar;
	public static int HammerSelect;
	public CanvasGroup HammerCanvas;
	private Image HammerBarRenderer;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("1") && HammerCanvas.alpha == 1 && HammerSelect == 0) {
			HammerSelect = 1;
			HammerBarRenderer = HammerSelectBar.GetComponent<Image> ();
			HammerBarRenderer.color = new Color (0f, 255f, 255f, 1f);

		}
		if (Input.GetKeyDown ("escape") && HammerCanvas.alpha == 1 && HammerSelect == 1) {
			HammerSelect = 0;
			HammerBarRenderer = HammerSelectBar.GetComponent<Image> ();
			HammerBarRenderer.color = new Color (0f, 0f, 255f, 1f);

		}
	
	}
}
