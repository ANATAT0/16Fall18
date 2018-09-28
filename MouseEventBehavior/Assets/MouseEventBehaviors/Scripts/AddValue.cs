using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class AddValue : ScriptableObject
{
	public FloatData ValueObj;

	public void AddValueToObj(FloatData Data)
	{
		ValueObj.Value += Data.Value;
	}

}
