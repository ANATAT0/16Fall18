using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumdropMonster : MonoBehaviour
{
	private void OnTriggerEnter(Collider2D col)
	{
		HealthBarGingerbread.health -= 10f;
	}
		
	
	
}
	

