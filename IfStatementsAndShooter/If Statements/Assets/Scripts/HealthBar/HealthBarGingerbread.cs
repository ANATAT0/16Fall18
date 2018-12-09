using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarGingerbread : MonoBehaviour
{
	Image HealthbarGingerbread;
	float maxHealth = 100f;
	public static float health;
	
	void Start ()
	{
		HealthbarGingerbread = GetComponent<Image>();
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update ()
	{
		HealthbarGingerbread.fillAmount = health / maxHealth;
	}
}
