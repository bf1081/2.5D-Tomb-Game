using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {
	public Transform hand;
	public Transform player;
	public float speed = 1.5f;
	private Vector3 target;
	public float radius = 5;
	//private Vector3 wPos;
	// Use this for initialization
	void Start () {
		target = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 wPos = Input.mousePosition;
		wPos.z = player.position.z - Camera.main.transform.position.z;
		wPos = Camera.main.ScreenToWorldPoint(wPos);
		Vector3 direction = wPos - player.position;
		direction = Vector3.ClampMagnitude (direction, radius);
		hand.position = player.position + direction;
	
		//	target = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	//	target.Normalize ();
		//	target.z = transform.position.z;
		//	Vector3 place = transform.position;
		//	transform.position = Vector3.MoveTowards (place, target, speed * Time.deltaTime);


	
	}
}
