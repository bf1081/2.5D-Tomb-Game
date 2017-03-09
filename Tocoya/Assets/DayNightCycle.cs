using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DayNightCycle : MonoBehaviour {

	public Color color2 = Color.red;
	public Color color1 = Color.blue;
	public Color color3 = Color.black;
	public float duration = 3.0F;
	public Light sun;
	public static int sunrise = 0;
	public float suntime = 0.01F;
	public float monstersspawntime;
	public int daynumber = 1;
	public float facts;
	public GameObject monster;
	public int monsternumber;
	public Text health;
	public Text Day;


	Camera camera;
	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
		camera.clearFlags = CameraClearFlags.SolidColor;
		sun.intensity = (float)sun.intensity;
		//StartCoroutine (Example ());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float t = Mathf.PingPong (Time.time, duration) / duration;
		camera.backgroundColor = Color.Lerp (color1, color2, t);
		//sun.intensity = (float)sun.intensity;
		if (sunrise == 0){
			
			sun.intensity = sun.intensity - 0.0002208F ;

	}
		if (sunrise == 1){
			
			sun.intensity = sun.intensity + 0.0002208F;
		}
		if (sun.intensity == 0){
			sunrise = 1;
		}
		if (sun.intensity == 2.8){
			sunrise = 0;
			daynumber = daynumber + 1;
			Survive.health = Survive.health + 1;
		}

		if (sun.intensity > 1.0){
			//Destroy (monster);
			monster.transform.position = new Vector2(10000,0);
		}
		monstersspawntime = sun.intensity;
		monsternumber = daynumber * 5;
		if (monstersspawntime <= 0.02208 && monstersspawntime > 0.0218592f) {
			Debug.Log ("Here come the monsters");
			for (int i = 0; i < monsternumber; i++) {
				//Debug.Log (i);
				Instantiate (monster, new Vector2 (Random.Range (-50, 135), 30), Quaternion.identity);
			}
	}
		Day.text = daynumber.ToString();
		health.text = Survive.health.ToString();
	}

	IEnumerator Example() {
		//sun.intensity = 2.8;
		yield return new WaitForSeconds (180);
		sunrise = 1;


	}
}
