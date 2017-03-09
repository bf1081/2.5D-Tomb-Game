using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject StraightAcrossPath;
	public GameObject PathMaker;
	//float level;
//	float piece;
	//float level = 5;
	// Use this for initialization
	void Start () {
	//	float level = Random.Range (0, 50);
		//for (int i = 0; i < 10; i++)
			Instantiate (StraightAcrossPath);
	}

	// Update is called once per frame
	void Update () {
	//	float piece = Random.Range (1,9);
	//	while (level > 0 ) {
		//	Vector3 position = new Vector3(transform.position.x, 0, transform.position.y);
		//	Instantiate(StraightAcrossPath, position, Quaternion.identity);
//	}
		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (StraightAcrossPath);
		}
}
}
