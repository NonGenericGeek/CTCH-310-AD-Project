/*
 * chaseScript.cs
 * by Logan Slater
 * 200356549
 * CTCH 310AD lab
 * 14 February 2018
 * Trevor Tomesh
 * 
 * mostly copied from simpleAI.cs, then modified, then the modifications deleted and replaced with the code from class.
 * 
 * When applied to a bus model, the bus moves like a dove... that was hit by a truck.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseScript : MonoBehaviour {

	public Transform target;
	public bool cat;
	public float speed;
	public float chaseDist;

	// does nothing.
	void Start () {
	}

	void Update () {

		// get distance between target and current object

		float dist = Vector3.Distance (target.position, transform.position);

		Vector3 local = target.transform.position - transform.position;
		local = local.normalized;
		//local = local * Time.deltaTime * speed;

		if (dist < chaseDist) {
			if (cat) // if cat, chase target. otherwise, run away from target.
				transform.Translate (local.x * Time.deltaTime * speed, 0.0f, local.z * Time.deltaTime * speed);
			else
				transform.Translate (local.x * Time.deltaTime * -speed, 0.0f, local.z * Time.deltaTime * -speed);
		}
	}
}
