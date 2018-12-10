using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public int health;

	public GameObject AttackEffect;

	
	void Update () 
	{
		if (health < 0)
		{
			Destroy(gameObject);
		}
		
	}

	public void TakeDamage(int damage)
	{
		Instantiate(AttackEffect, transform.position, Quaternion.identity);
		health -= damage;
		Debug.Log("damage Taken!");
	}
}
