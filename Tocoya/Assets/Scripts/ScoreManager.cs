using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public static float wood;
	public static float stone;
	public static float copper;
	public static float tin;
	public static float bronze;
	public Text bronzetext;
	public Text tintext;
	public Text stonetext;
	public Text woodtext;
	public Text coppertext;
	// Use this for initialization
	void Start () {
	//	woodtext = GetComponent <Text> ();
		wood = 0;
	//	stonetext = GetComponent <Text> ();
		stone = 0;
		copper = 0;
		tin = 0;
		bronze = 0;

	}
	
	// Update is called once per frame
	void Update () {
		woodtext.text = "" + Mathf.Round(wood);
		stonetext.text = "" + Mathf.Round (stone);
		coppertext.text = "" + Mathf.Round (copper);
		tintext.text = "" + Mathf.Round (tin);
		bronzetext.text = "" + Mathf.Round (bronze);
		if( Input.GetKeyDown ("p")) {
			wood = wood + 200;
			stone = stone + 200;
			copper = copper + 200;
			tin = tin + 200;
			bronze = bronze + 200;
		}
	}
}
