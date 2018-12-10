using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{

	public int damageToGive;
	
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player")
		{
			other.gameObject.GetComponent<PlayerHealthManager>() .HurtPlayer(damageToGive);
		}
	}
}
