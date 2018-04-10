/*
 * playerHealth.cs
 * by Logan Slater
 * 200356549
 * CTCH 310AD lab
 * 13 March 2018
 * Trevor Tomesh
 * 
 * A health bar script. It doesn't do anything unless "party mode" is turned on.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

	public Slider healthBar; // The health bar.
	public bool party = false; // Party mode is not on by default.

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Non-party mode code would go here.
		if (party) {
			healthBar.value = 50 + 50 * Mathf.Cos (Time.fixedTime); // Oscillates between 100 and 0 using a cosine wave.
		}
	}
}