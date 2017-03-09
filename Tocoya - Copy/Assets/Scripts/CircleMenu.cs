using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CircleMenu : MonoBehaviour {
	public List<MenuButton> buttons = new List<MenuButton> ();
	private Vector2 Mouseposition;
	private Vector2 fromVector2M = new Vector2 (0.5f, 1.0f);
	private Vector2 centercircle = new Vector2 (0.5f, 0.5f);
	private Vector2 toVector2M;
	public Text itemtext;
	public Text Woodtext;
	public Text Stonetext;
	public int menuItems;
	public int CurMenuItem; //current menu item
	public int OldMenuItem;
	public CanvasGroup craftingpercent;
	public CanvasGroup craftingcanvas;
	public CanvasGroup craftingcanvastools;
	public CanvasGroup crafttingcanvasweapons;
	public CanvasGroup craftingcanvasbuilding;
	public static int WhichBlock;
	public static int MakingHammer;
	public static int MakingAxe;
	//public Image sprender;
	public static int WhichMenu;
	// Use this for initialization
	void Start () {
		menuItems = buttons.Count;
		foreach (MenuButton button in buttons) {
			button.sceneimage.color = button.NormalColor;
		}
		CurMenuItem = 0;
		OldMenuItem = 0;
	}

	IEnumerator WhichMenu1() {
		yield return new WaitForSeconds (1/100);
		WhichMenu = 1;
	}

	IEnumerator WhichBlock1() {
		yield return new WaitForSeconds (1/100);
		WhichBlock = 1;
		WhichMenu = 0;
	}

	IEnumerator WhichBlock2() {
		yield return new WaitForSeconds (1/100);
		WhichBlock = 2;
		WhichMenu = 0;
	}



	// Update is called once per frame
	void Update () {


		GetCurrentMenuItem ();
		if (Input.GetButtonDown ("Fire1"))
			ButtonAction (); // thing that happens
		if (CurMenuItem == 0 && WhichMenu == 0) { // where button one stuff happens
			itemtext.text = "Tools";
			Woodtext.text = "";
			Stonetext.text = "";

		}
		if (CurMenuItem == 1 && WhichMenu == 0) { // where button one stuff happens
			itemtext.text = "Weapons";
			Woodtext.text = "";
			Stonetext.text = "";
		
		}
		if (CurMenuItem == 2 && WhichMenu == 0) { // where button one stuff happens
			itemtext.text = "Devices";
			Woodtext.text = "";
			Stonetext.text = "";

		}

		if (CurMenuItem == 0 && WhichMenu == 1) { // where button one stuff happens
			itemtext.text = "Hammer";
			Woodtext.text = "";
			Stonetext.text = "";

		}
		if (CurMenuItem == 1 && WhichMenu == 1) { // where button one stuff happens
			itemtext.text = "Axe";
			Woodtext.text = "";
			Stonetext.text = "";

		}
		if (CurMenuItem == 2 && WhichMenu == 1) { // where button one stuff happens
			itemtext.text = "Pickaxe";
			Woodtext.text = "";
			Stonetext.text = "";

		}

		if (CurMenuItem == 0 && WhichMenu == 2) { // where button one stuff happens
			itemtext.text = "Club";
			Woodtext.text = "";
			Stonetext.text = "";

		}
		if (CurMenuItem == 1 && WhichMenu == 2) { // where button one stuff happens
			itemtext.text = "Spear";
			Woodtext.text = "";
			Stonetext.text = "";

		}
		if (CurMenuItem == 2 && WhichMenu == 2) { // where button one stuff happens
			itemtext.text = "Bow";
			Woodtext.text = "";
			Stonetext.text = "";

		}
		if (CurMenuItem == 3 && WhichMenu == 2) { // where button one stuff happens
			itemtext.text = "Sword";
			Woodtext.text = "";
			Stonetext.text = "";

		}
		if (CurMenuItem == 4 && WhichMenu == 2) { // where button one stuff happens
			itemtext.text = "Crossbow";
			Woodtext.text = "";
			Stonetext.text = "";

		}
		if (CurMenuItem == 5 && WhichMenu == 2) { // where button one stuff happens
			itemtext.text = "Rifle";
			Woodtext.text = "";
			Stonetext.text = "";

		}
		if (CurMenuItem == 0 && WhichMenu == 3) { // where button one stuff happens
			itemtext.text = "Stuff";
			Woodtext.text = "";
			Stonetext.text = "";

		}
	
	
	}

	public void GetCurrentMenuItem() {
		Mouseposition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);

		toVector2M = new Vector2 (Mouseposition.x / Screen.width, Mouseposition.y / Screen.height);
		float angle = (Mathf.Atan2 (fromVector2M.y - centercircle.y, fromVector2M.x - centercircle.x) - Mathf.Atan2 (toVector2M.y - centercircle.y, toVector2M.x - centercircle.x)) * Mathf.Rad2Deg; //probably going to bitch me out
		if (angle < 0)
			angle += 360;

		CurMenuItem = (int) (angle / (360 / menuItems)); // cutting the pie
		if (CurMenuItem != OldMenuItem) {
			buttons [OldMenuItem].sceneimage.color = buttons [OldMenuItem].NormalColor;
			OldMenuItem = CurMenuItem;
			buttons [CurMenuItem].sceneimage.color = buttons [CurMenuItem].HighlightedColor;

		}
	

	}

	public void ButtonAction () {

		buttons [CurMenuItem].sceneimage.color = buttons [CurMenuItem].PressedColor;
		if (CurMenuItem == 0 && WhichMenu == 0) { // where button one stuff happens
			//craftingcanvas.alpha = 1f;

			StartCoroutine (WhichMenu1 ());
			
		}

		if (CurMenuItem == 0 && WhichMenu == 1 && ScoreManager.wood >= 100 && ScoreManager.stone >= 50 && craftingcanvastools.alpha == 1) { // where button one stuff happens
			ScoreManager.wood = ScoreManager.wood - 100;
			ScoreManager.stone = ScoreManager.stone - 50;
			craftingpercent.alpha = 1f;
			MakingHammer = 1;

		}
		if (CurMenuItem == 1 && WhichMenu == 1 && ScoreManager.wood >= 150 && ScoreManager.stone >= 100 && craftingcanvastools.alpha == 1) { // where button one stuff happens
			ScoreManager.wood = ScoreManager.wood - 150;
			ScoreManager.stone = ScoreManager.stone - 100;
			craftingpercent.alpha = 1f;
			MakingAxe = 1;

		}
		if (CurMenuItem == 1 && WhichMenu == 0) { // where button one stuff happens
			//craftingcanvas.alpha = 1f;
			WhichMenu = 2;
		}
		if (CurMenuItem == 1 && WhichMenu == 3) { // where button one stuff happens
			craftingcanvasbuilding.alpha = 0f;
			//craftingcanvasbuilding.blocksRaycasts = false;
			//craftingcanvasbuilding.interactable = false;
			StartCoroutine (WhichBlock1 ());
		}
		if (CurMenuItem == 2 && WhichMenu == 3) { // where button one stuff happens
			craftingcanvasbuilding.alpha = 0f;
			//craftingcanvasbuilding.blocksRaycasts = false;
			//craftingcanvasbuilding.interactable = false;
			StartCoroutine (WhichBlock2 ());
		}
	}
	[System.Serializable]
	public class MenuButton {

		public string name;
		public Image sceneimage;
		public Color NormalColor = Color.white;
		public Color HighlightedColor = Color.grey;
		public Color PressedColor = Color.gray;
	}
}
