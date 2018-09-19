using UnityEngine;

[CreateAssetMenu]

public class AddValue : ScriptableObject
{
	public FloatData ValueObj;
	public FloatData MaxValue;
	public Floatdata MinValue;

	public UnityEvent EventMax;
	public UnityEvent EventMin;
	
	public void AddValueToObject(FloatData data)
	{
		ValueObj.Value += data.Value;

		if (VlaueObj.Value >= Maxvalue.Value)
		{
			EventMax.Invoke();
		}

		if (ValueObj.Value <= MinValue.Value)
		{
			Event.Invoke(); 
		}
	}
	

}

