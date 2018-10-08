using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour 
{
	IEnumerator Start () 
	{
		yield return new WaitForSeconds(5);
		Destroy((gameObject));
	}

	private void OnCollisionEnter(Collision other)
	{
		Destroy(gameObject);
		Destroy(other.gameObject);
	}
}
