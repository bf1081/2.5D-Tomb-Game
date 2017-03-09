using UnityEngine;
using System.Collections;

public class GroundCreature : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	public int dmg = 0;
	public float knockForce = 0f;
	public Rigidbody2D test;
	public float health = 5;
	public Vector3 mouseDelta = Vector3.zero;
	private Vector3 lastMousePosition = Vector3.zero;
	public GameObject Particle;
	public int monsternumber;
	public GameObject monster;

	private Transform myTransform;

	void Awake() {

		myTransform = transform;
	}
	// Use this for initialization
	void Start () {
	
		GameObject go = GameObject.FindGameObjectWithTag ("Player");

		target = go.transform;
	}
	
	// Update is called once per frame
	void Update () {
		//monsternumber = DayNightCycle.daynumber * 5;
		Vector3 dir = target.position - myTransform.position;
		if (dir != Vector3.zero) {
			myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.FromToRotation (Vector3.right, dir), rotationSpeed * Time.deltaTime); 

			//if (DayNightCycle.monstersspawntime < 1f) {
			//	Debug.Log ("Here come the monsters");
			//	for (int i = 0; i < monsternumber; i++) {
				//	Debug.Log (i);
				//	Instantiate (monster, new Vector2 (Random.Range (-50, 80), 5), Quaternion.identity);
			//	}
			//	Debug.Log (DayNightCycle.monstersspawntime);

			//}
		


		}
		myTransform.position += (target.position - myTransform.position).normalized * moveSpeed * Time.deltaTime;
		mouseDelta = Input.mousePosition - lastMousePosition;

		lastMousePosition = Input.mousePosition;
	}

	void OnCollisionEnter2D(Collision2D target) {
		if (target.gameObject.tag == "Player") {
			Debug.Log ("This is happening");
			Vector2 directionVector = target.transform.position - transform.position;
			directionVector.Normalize ();
			Rigidbody2D targetPlayerBody = target.gameObject.GetComponent<Rigidbody2D> ();
			ForceMode2D mode = ForceMode2D.Impulse;
			targetPlayerBody.AddForce (Vector3.right * knockForce, mode);
			Survive.health = Survive.health - 1;

		
		}

	


		if(target.gameObject.tag == "hand" && mouseDelta.x > 200 ) {
			Debug.Log ("zombiehit");
			health = health - 1;
			Instantiate (Particle, target.transform.position, target.transform.rotation);
			//ScoreManager.wood += mouseDelta.x / 200;
			//		chips.GetComponent<ParticleSystem> ().enableEmission = true;
			//		StartCoroutine (stopSparkles ());
		}

		if (health ==0) {
			Destroy (monster);
		}
	}



}
