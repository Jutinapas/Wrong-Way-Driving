using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour {

	public Text text;
	public Transform player;

	public float score = 0f;

	// Use this for initialization
	void Start () 
	{	
		text.text = score + "%";
		
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if (score >= 100)
			text.text = score.ToString("0") + "%";
		else
			score = player.transform.position.y / 2;
			text.text = score.ToString("0") + "%";
		
	}
}
