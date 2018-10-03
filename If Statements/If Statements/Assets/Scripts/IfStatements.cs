using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

	public bool LightOn;
	public string Password;
	public int A, B, C;

	void Update()
	{
		if (LightOn)
		{
			print("The light is on.");
		}

		if (Password == "OU812")
		{
			print("You are correct!");
		}

		if (C == A + B)
		{
			print("C");
		}
	}

}
