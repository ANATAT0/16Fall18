using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{

	public Vector3 Speed;
	// Use this for initialization
	private void Update()
	{
		transform.Rotate(Speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
