using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WhichToolHeld : MonoBehaviour {
	public GameObject HammerSelectBar;
	public GameObject AxeSelectBar;
	public static int HammerSelect;
	public static int AxeSelect;
	public CanvasGroup HammerCanvas;
	public CanvasGroup AxeCanvas;
	private Image HammerBarRenderer;
	private Image AxeBarRenderer;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("1") && HammerCanvas.alpha == 1 && HammerSelect == 0) {
			AxeSelect = 0;
			HammerSelect = 1;
			HammerBarRenderer = HammerSelectBar.GetComponent<Image> ();
			HammerBarRenderer.color = new Color (0f, 255f, 255f, 1f);
			AxeBarRenderer = AxeSelectBar.GetComponent<Image> ();
			AxeBarRenderer.color = new Color (0f, 0f, 255f, 1f);

		}

		if (Input.GetKeyDown ("2") && AxeCanvas.alpha == 1 && AxeSelect == 0) {
			AxeSelect = 1;
			HammerSelect = 0;
			AxeBarRenderer = AxeSelectBar.GetComponent<Image> ();
			AxeBarRenderer.color = new Color (0f, 255f, 255f, 1f);
			HammerBarRenderer = HammerSelectBar.GetComponent<Image> ();
			HammerBarRenderer.color = new Color (0f, 0f, 255f, 1f);

		}
		if (Input.GetKeyDown ("escape")) {
			HammerSelect = 0;
			HammerBarRenderer = HammerSelectBar.GetComponent<Image> ();
			HammerBarRenderer.color = new Color (0f, 0f, 255f, 1f);
			AxeSelect = 0;
			AxeBarRenderer = AxeSelectBar.GetComponent<Image> ();
			AxeBarRenderer.color = new Color (0f, 0f, 255f, 1f);

		}
	
	}
}
