using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoney : MonoBehaviour
{

	public int Money = 10;
	
	
	public void AddMoreMore (int money)
	{
		Money += money;
	}
	
	
	void Update () {
		
	}
}
