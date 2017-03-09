using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {
	
	Transform target;
	Transform enemyTransform;
	public float speed = 3f;
	public float rotationSpeed = 10f;
	Vector3 upAxis = new Vector3 (0f, 0f, -1f);


	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate() {

		//target = GameObject.FindWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

	//	transform.LookAt (target.position, upAxis);
		//transform.eulerAngles = new Vector3 (0f, 0f, transform.eulerAngles.z);

		//enemyTransform.position += transform.up * speed * Time.deltaTime;
	
	}
}
