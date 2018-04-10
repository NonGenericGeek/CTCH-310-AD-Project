using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	float speed = 0.1f;
	float baseSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		move ();
	}

	void move () {
		if (Input.GetKey (KeyCode.LeftShift))
			speed = baseSpeed * 100.0f;
		else if (Input.GetKey (KeyCode.Space))
			speed = baseSpeed * 10.0f;
		else
			speed = baseSpeed;
		
		if (Input.GetKey (KeyCode.W))
			transform.Translate (0f, 0f, speed);
		if (Input.GetKey (KeyCode.S))
			transform.Translate (0f, 0f, -speed);
		if (Input.GetKey (KeyCode.A))
			transform.Translate (-speed, 0f, 0f);
		if (Input.GetKey (KeyCode.D))
			transform.Translate (speed, 0f, 0f);

		float h = Input.GetAxis ("Mouse X");
		float v = Input.GetAxis ("Mouse Y");
		transform.Rotate (-v,h,0f);
	}
}