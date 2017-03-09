using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CraftingPercent : MonoBehaviour {

	public Text text;
	public CanvasGroup canvasgroup;
	float percent;
	public static int HasHammer = 0;
	public static int HasAxe = 0;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (canvasgroup.alpha == 1 && percent <= 500) {
			percent = percent + 1;
		}
		text.text = percent / 5 + "%";
		if (percent == 500 && CircleMenu.MakingHammer == 1) {
			canvasgroup.alpha = 0;
			percent = 0;
			HasHammer = 1;
			CircleMenu.MakingHammer = 0;
		}

		if (percent == 500 && CircleMenu.MakingAxe == 1) {
			canvasgroup.alpha = 0;
			percent = 0;
			HasAxe = 1;
			CircleMenu.MakingAxe = 0;
		}
		}





	
	}
