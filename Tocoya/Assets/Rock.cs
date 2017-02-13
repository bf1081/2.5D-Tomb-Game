using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {
	public Vector3 mouseDelta = Vector3.zero;
	public GameObject Hand;
	public GameObject Boulder;
	public int health;
	private Vector3 lastMousePosition = Vector3.zero;
	public GameObject Particle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		mouseDelta = Input.mousePosition - lastMousePosition;

		lastMousePosition = Input.mousePosition;
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("hit");
		if(col.gameObject.tag == "hand" && mouseDelta.x > 200 ) {
			Debug.Log ("hit");
			health = health - 1;
			Instantiate (Particle, col.transform.position, col.transform.rotation);
			//		chips.GetComponent<ParticleSystem> ().enableEmission = true;
			//		StartCoroutine (stopSparkles ());
		}


		if (health <= 0) {
			Destroy (Boulder);
		}
	}
}
