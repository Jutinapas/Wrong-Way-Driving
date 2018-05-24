using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject howTo;
	public GameObject menu;


	public void StartGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void HowTo()
	{	
		menu.SetActive (false);
		howTo.SetActive (true);
	}

	public void Back()
	{
		howTo.SetActive (false);
		menu.SetActive (true);
	}

}
