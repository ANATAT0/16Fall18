using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformObject : MonoBehaviour
{

	public Vector3 Movement;
	
	void Start () 
	{
		
	}
	
	void Update ()
	{
		//transform.Translate(Movement);
		transform.Rotate(Movement);
	}
}
