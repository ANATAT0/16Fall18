/* not in use

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class HealthCube : MonoBehaviour

{ 
	public int Health;
	public int NumOfBars;

	public Image[] Bar;
	public Sprite RedBar;
	public Sprite EmptyBar;


	void Update()
	{
		if (Health > NumOfBars)
		{
			Health = NumOfBars;
		}
		
		
		for (int i = 0; i < Bar.Length; i++)
		{
			
			if (Health < 0)
			{
				gameObject.SetActive(false);
			
			}	
			
			if (i < Health)
			{
				Bar[i].sprite = RedBar;
			}
			else
			{
				Bar[i].sprite = EmptyBar;
			}
			
			if (i< NumOfBars )
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
	

*/