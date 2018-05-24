using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;
	public Animator animator;

	void OnCollisionEnter2D (Collision2D other)
	{	
		animator.SetTrigger ("PlayerExplosion");
		movement.enabled = false;
		FindObjectOfType<GameManager> ().EndGame ();
	}

}
