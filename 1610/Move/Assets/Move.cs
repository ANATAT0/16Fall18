﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public floate Speed;
	public Vector3 MoveSpeed;
	public Vector3 RotateSpeed;

	private void Update()
	{

		MoveSpeed.x = Speed*Input.GetAxis("Horizontal");
		MoveSpeed *= Time.deltaTime;
		
		transform.Translate(MoveSpeed);
		transform.Rotate(RotateSpeed);

	}


}
