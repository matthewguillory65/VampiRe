using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TestObject : ScriptableObject {

	public void Print(string value)
	{
		Debug.Log(value);
	}
}
