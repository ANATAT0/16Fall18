using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarGingerbread : MonoBehaviour
{
	Image Healthbar;
	float maxHealth = 100f;
	public static float health;
	
	
	void Start ()
	{
		Healthbar = GetComponent<Image> ();
		health = maxHealth;
	}
	
	
	void Update ()
	{
		Healthbar.fillAmount = health / maxHealth;
	}
}
