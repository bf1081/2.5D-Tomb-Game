using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 3; // speed in meters per second
	bool jumping;
	public float jumpSpd;
	private float xpos;
	float curJumpVel;
	float startY;
	public float gravity;
	// Use this for initialization
	void Start () {
		startY = transform.position.y;
	}

	// Update is called once per frame
	void Update () {
		Vector3 Dir = Vector3.zero;
		Dir.z = Input.GetAxis("Horizontal"); // get result of AD keys in X
		//Dir.z = Input.GetAxis("Vertical"); // get result of WS keys in Z
		// move this object at frame rate independent speed:
		transform.position += Dir * speed * Time.deltaTime;

	
	
		DealWithInput ();
		if (jumping) {
			DealWithJumping ();
		}
	

	}

	void DealWithInput () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (jumping) {
				//Throwball ();
			} else {
				Jump ();
			}
		}
	}

	void Jump() {
		jumping = true;
		curJumpVel = jumpSpd;
	}

	void DealWithJumping() {
		transform.position += new Vector3 (0, curJumpVel, 0);
		curJumpVel -= gravity;
		if (transform.position.y <= startY) {
			jumping = false;
			transform.position = new Vector3 (transform.position.x, startY, 0);
		}
	}
}
