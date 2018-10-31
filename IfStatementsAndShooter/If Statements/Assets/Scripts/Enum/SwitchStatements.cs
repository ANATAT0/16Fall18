using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatements : MonoBehaviour
{

	public GameStates.States GameState;
	public UnityEvent Starting, Loading, Playing, GameOver, Ending;
	
	void Update () 
	{
		switch (GameState)
		{
				case GameStates.States.Starting:
					print("We are starting the Game");
					break;
				
				case GameStates.States.Loading:
					print("We are loading the Game");
					break;
				
				case GameStates.States.Playing:
					print("We are playing the Game");
					break;
				
				case GameStates.States.GameOver:
					print("GameOver");
					break;
				
				case GameStates.States.Ending:
					print("We are ending the Game");
					break;
				
				case GameStates.States.Revive:
					print("We have revived from the dead");
					break;
				
				case GameStates.States.RecoverHealth:
					print("Health Restored!");
					break;
				
				case GameStates.States.EatDonut:
					print("Time for a donut");
					break;
				
				case GameStates.States.DrinkPotion:
					print("Drinking the potion");
					break;
				
				case GameStates.States.UseSpecialAttack:
					print("Super Special Attack: Donut Punch!");
					break;
				
				case GameStates.States.UsePrimaryAttack:
					print("Use Main Fire");
					break;
				
				case GameStates.States.UseAlternativeAttack:
					print("Use Alternate Fire");
					break;
		}	
		
	}
	
}
