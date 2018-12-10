using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCube : MonoBehaviour
{
	public int health;
	public int numOfBars;

	public Image[] Bar;
	public Sprite RedBar;
	public Sprite EmptyBar;

	void Update()
	{
		if (health > numOfBars)
		{
			health = numOfBars;
		}
		
		
		for (int i = 0; i < Bar.Length; i++)
		{
			if (health < 0)
			{
				gameObject.SetActive(false);
			
			}	
			
			if (i < health)
			{
				Bar[i].sprite = RedBar;
			}
			else
			{
				Bar[i].sprite = EmptyBar;
			}
			
			if (i< numOfBars )
			{
				Bar[i].enabled = true;
				}
			else
			{
				Bar[i].enabled = false;
			}
		}
	}

}
	

