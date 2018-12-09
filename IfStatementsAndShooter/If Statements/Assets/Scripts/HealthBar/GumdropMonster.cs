using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumdropMonster : MonoBehaviour
{
	private void OnTriggerEnter(BoxCollider col)
	{
		HealthBarGingerbread.health -= 10f;
	}
		
	
	
}
	

