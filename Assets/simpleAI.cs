/*
 * simpleAI script
 * by Logan Slater
 * 200356549
 * CTCH 310AD lab
 * 6 February 2018
 * Trevor Tomesh
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleAI : MonoBehaviour {

	public int IQ = 5;
	public Transform target;
	public bool cat;
	int chaseState = 1;

	// Greets via console, based on IQ.
	void Start () {
		Greet ();
		// Finds the camera and prints its position to the console; I was doing something else.
		print(GameObject.Find("Camera").gameObject.transform.position);
	}
	
	void Update () {
		CatAndMoose();
	}

	// It's "cat and mouse," but spoken with an accent.
	// Isn't actually really the lab objective, and doesn't completely work as a result.
	void CatAndMoose() {
		switch(chaseState) {
		case 1: // wander
			if (Vector3.Distance (target.position, transform.position) <= 50.0f)
				chaseState = 2;
			else {
				if (cat)
					transform.Translate (0.05f, 0f, 0f);
				else
					transform.Translate (0f, 0f, 0.1f);
			

				transform.Rotate (0f,Random.Range(-10f, 10f),0f);
			}
			break;
		case 2: // chase
			if (Vector3.Distance (target.position, transform.position) > 50.0f)
				chaseState = 1;
			else {

			}
			break;
		default:
			break;
		}

	}

	// Conversation starters, from most intelligent to least intelligent.
	void Greet() {
		switch(IQ) {
		case 5:
			print("Why, hello there! Would you like to discuss quantum mechanics, good sir/madam/any variation thereupon?");
			break;
		case 4:
			print("Hello, and good day!");
			break;
		case 3:
			print("<Insert internet meme here>!");
			break;
		case 2:
			print("U w0t m8 1v1 me quicksc0p3s only");
			break;
		case 1:
			print("<Insert game you dislike here> is an excellent game."); // This is satire.
			break;
		default:
			print("Incorrect IQ. Try again.");
			break;
		}
	}
}
