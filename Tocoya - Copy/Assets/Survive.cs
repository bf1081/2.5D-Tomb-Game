using UnityEngine;
using System.Collections;

public class Survive : MonoBehaviour {

	public static int health = 10;
	public GameObject character;
	public CanvasGroup YouLose;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (health <= 0) {
			Destroy (character);
			YouLose.alpha = 1F;
		}
	
	}

	void OnCollision2D(Collider2D col) {

		Vector3 directionVector = col.transform.position - transform.position;
		directionVector.Normalize ();

		Rigidbody2D rb = col.GetComponent<Rigidbody2D> ();

		if(rb != null) {

			float forceMagnitude = 20f;

			ForceMode2D mode = ForceMode2D.Impulse;

			if (col.gameObject.tag == "enemy") {

				//rb.AddForce (directionVector * forceMagnitude, mode);

			}

		
	}
}
}
