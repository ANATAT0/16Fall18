using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumdropMonster : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
		HealthBarGingerbread.health -= 10f;
	}
	
}
	

