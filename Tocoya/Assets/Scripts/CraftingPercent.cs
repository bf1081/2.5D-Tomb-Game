using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CraftingPercent : MonoBehaviour {

	public Text text;
	public CanvasGroup canvasgroup;
	float percent;
	int HasHammer = 0;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (canvasgroup.alpha == 1 && percent <= 500) {
			percent = percent + 1;
		}
		text.text = percent / 5 + "%";
		if (percent == 500) {
			canvasgroup.alpha = 0;
			percent = 0;
			HasHammer = 1;
		}
		}





	
	}
