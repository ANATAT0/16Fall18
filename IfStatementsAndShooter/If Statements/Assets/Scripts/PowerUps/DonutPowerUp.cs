using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using UnityEngine.Events;

public class DonutPowerUp : MonoBehaviour
{
	public int donutValue = 5;
	public static UnityAction<int> UpdateDonut;

	private void OnTriggerEnter(Collider col)
	{
		UpdateDonut(donutValue);
		gameObject.SetActive(false);
	}
}

