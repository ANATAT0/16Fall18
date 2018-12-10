using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{

	private GingerbreadCharacterMover player;

	void Start()
	{
		player = gameObject.GetComponent("Player").GetComponent<GingerbreadCharacterMover>();
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			player.Damage(3);
		}
	}
}
