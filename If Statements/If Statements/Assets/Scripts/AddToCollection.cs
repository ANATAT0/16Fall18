using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu]

public class AddToCollection : ScriptableObject
{
	public ObjectCollection Collection;
	
	public void Call(ScriptableObject obj)
	{
		Collection.ObjectList.Add(obj);
	}
	
}
