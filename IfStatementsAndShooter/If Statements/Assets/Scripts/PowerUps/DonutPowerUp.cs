﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DonutPowerUp : MonoBehaviour
{

	private GingerbreadCharacterMover player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<GingerbreadCharacterMover>();
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			player.Damage(-3);
			Destroy(gameObject);
		}
	}
}
