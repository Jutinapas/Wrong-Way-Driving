using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	public Rigidbody2D rb2d;
	public float speed = 1000f;
	public float sideSpeed = 50f;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.AddForce(new Vector2 (0, speed));
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Input.GetKey ("d")) {
			rb2d.AddForce (new Vector2 (sideSpeed, 0));
		}
		if (Input.GetKey ("a")) {
			rb2d.AddForce (new Vector2 (-sideSpeed, 0));
		}

		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}

	}

}
