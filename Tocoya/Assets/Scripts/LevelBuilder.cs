using UnityEngine;
using System.Collections;

public class LevelBuilder : MonoBehaviour {
	public GameObject StraightAcrossPath;
	public Transform PathMaker;
	private int path = 5;
	float path2 = 5;
	// Use this for initialization
	void Start () {
		int path = Random.Range (0, 50);
		Debug.Log (path2);
	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < path2; i++) {
			Instantiate (StraightAcrossPath, PathMaker.position, PathMaker.rotation);
		}
	}
}
