using UnityEngine;
using System.Collections;

public class SpawnRooms : MonoBehaviour {
	public GameObject[] Rooms;
	public Transform spawnpos;
	int roomselector;
	public int roomamount;
	public float cameracorrectx;
	public float cameracorrecty;
	//public float roomspawndistanceup;
	//public float roomspawndistancedown;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		roomselector = Random.Range (0, roomamount);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "RoomSpawn") {
			Debug.Log ("dr;ojmnf");
			//roomselector belongs in the brackets
			Instantiate (Rooms [1], new Vector3(spawnpos.position.x+cameracorrectx + 2, spawnpos.position.y-cameracorrecty, 0), Quaternion.identity);
			Destroy (col.gameObject);
		}
	}
}
