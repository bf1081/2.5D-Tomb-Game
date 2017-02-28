using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {
	public Vector3 mouseDelta = Vector3.zero;
	public GameObject Hand;
	public GameObject Trunk;
	public int health;
	private Vector3 lastMousePosition = Vector3.zero;
	public GameObject Particle;
	//public Transform chips;
	// Use this for initialization
	void Start () {
	//	chips.GetComponent<ParticleSystem> ().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		mouseDelta = Input.mousePosition - lastMousePosition;

		lastMousePosition = Input.mousePosition;

	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("hit");
		if(col.gameObject.tag == "hand" && mouseDelta.x > 200 && WhichToolHeld.HammerSelect == 0 ) {
			Debug.Log ("hit");
			health = health - 1;
			Instantiate (Particle, col.transform.position, col.transform.rotation);
			ScoreManager.wood += mouseDelta.x / 200;
	//		chips.GetComponent<ParticleSystem> ().enableEmission = true;
	//		StartCoroutine (stopSparkles ());
		}


		if (health <= 0) {
			Destroy (Trunk);
		}
}

//	IEnumerator stopSparkles() {

	//	yield return new WaitForSeconds (.4f);
	//	chips.GetComponent<ParticleSystem> ().enableEmission = false;

	//}
}
