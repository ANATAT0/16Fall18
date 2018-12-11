using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLeveUI;

	public void CompleteLevel()
	{
		completeLeveUI.SetActive(true);
		Debug.Log("You Made It Home");
	}


	public void EndGame()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("The Cookie has Crumbled");

		}	
	}
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
