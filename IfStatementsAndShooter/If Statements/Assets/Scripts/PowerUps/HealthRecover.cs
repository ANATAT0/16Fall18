/* not using

using UnityEngine;

public class HealthRecover : MonoBehaviour
{
	GingerbreadCharacterMover CurrentHealth;

	public float healthBonus = 3f;

	private void Awake()
	{
		CurrentHealth = FindObjectOfType<GingerbreadCharacterMover>();
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (GingerbreadCharacterMover.CurrentHealth < GingerbreadCharacterMover.MaxHealth)
		{
			Destroy(gameObject);
			GingerbreadCharacterMover.CurrentHealth = GingerbreadCharacterMover + healthBonus;
		}
	}
}
*/