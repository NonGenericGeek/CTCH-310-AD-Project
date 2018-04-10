using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

	public AudioClip shootSound;
	public GameObject bullet;
	public Transform bulletSpawn;
	public float bulletSpeed = 10.0f;

	private AudioSource source;
	private float volLowRange = .5f;
	private float volHighRange = 1.0f;

	void Awake () {
		source = GetComponent<AudioSource> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Fire();
		}

	}

	void Fire() {
		float vol = Random.Range (volLowRange, volHighRange);
		var pew = Instantiate (bullet, bulletSpawn.position + bulletSpawn.forward, bulletSpawn.rotation);
		pew.GetComponent<Rigidbody> ().velocity = pew.transform.forward * bulletSpeed;
		source.PlayOneShot (shootSound, vol);
		Destroy (pew, 2.0f);
	}
}
