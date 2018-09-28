using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{

	public UnityEvent Enable;
	public UnityEvent Trigger;
	
	void OnEnable()
	{
		Enable.Invoke();
	}

	void OnTriggerEnter()
	{
		Trigger.Invoke();
	}
	
}
