using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {
	public Vector3 mouseDelta = Vector3.zero;
	public GameObject Hand;
	public GameObject Trunk;
	public int health;
	private Vector3 lastMousePosition = Vector3.zero;
	public GameObject Particle;
	public int Axehold = 0;
	public GameObject Axe;
	public SpriteRenderer AxeRender;
	//public Transform chips;
	// Use this for initialization
	void Start () {
	//	chips.GetComponent<ParticleSystem> ().enableEmission = false;
	}

	// Update is called once per frame
	void Update () {

		if (WhichToolHeld.AxeSelect == 1) {
			AxeRender = Axe.GetComponent<SpriteRenderer> ();
			AxeRender.enabled = true;
		}

		if (WhichToolHeld.AxeSelect == 0) {
			AxeRender = Axe.GetComponent<SpriteRenderer> ();
			AxeRender.enabled = false;
		}
		
		mouseDelta = Input.mousePosition - lastMousePosition;

		lastMousePosition = Input.mousePosition;

	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//Debug.Log ("hit");
		if(col.gameObject.tag == "hand" && mouseDelta.x > 200 && WhichToolHeld.HammerSelect == 0 && WhichToolHeld.AxeSelect == 0 ) {
		//	Debug.Log ("hit");
			health = health - 1;
			Instantiate (Particle, col.transform.position, col.transform.rotation);
			ScoreManager.wood += mouseDelta.x / 200;
	//		chips.GetComponent<ParticleSystem> ().enableEmission = true;
	//		StartCoroutine (stopSparkles ());
		}

	//	if(col.gameObject.tag == "enemy") {
			//	Debug.Log ("hit");
	//		health = health - 5;
		//	Instantiate (Particle, col.transform.position, col.transform.rotation);

			//		chips.GetComponent<ParticleSystem> ().enableEmission = true;
			//		StartCoroutine (stopSparkles ());
	//	}

		if(col.gameObject.tag == "hand" && mouseDelta.x < -200 && WhichToolHeld.HammerSelect == 0 && WhichToolHeld.AxeSelect == 0 ) {
			//	Debug.Log ("hit");
			health = health - 1;
			Instantiate (Particle, col.transform.position, col.transform.rotation);
			ScoreManager.wood += -mouseDelta.x / 200;
			//		chips.GetComponent<ParticleSystem> ().enableEmission = true;
			//		StartCoroutine (stopSparkles ());
		}

		if(col.gameObject.tag == "hand" && mouseDelta.x > 200 && WhichToolHeld.HammerSelect == 0 && WhichToolHeld.AxeSelect == 1 ) {
		//	Debug.Log ("hit");
			health = health - (1 + 1/2);
			Instantiate (Particle, col.transform.position, col.transform.rotation);
			ScoreManager.wood += mouseDelta.x / 50;
			//		chips.GetComponent<ParticleSystem> ().enableEmission = true;
			//		StartCoroutine (stopSparkles ());
		}

		if(col.gameObject.tag == "hand" && mouseDelta.x < -200 && WhichToolHeld.HammerSelect == 0 && WhichToolHeld.AxeSelect == 1 ) {
			//	Debug.Log ("hit");
			health = health - (1 + 1/2);
			Instantiate (Particle, col.transform.position, col.transform.rotation);
			ScoreManager.wood += -mouseDelta.x / 50;
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
