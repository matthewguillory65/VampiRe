using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int currentValue=1;

    public int startCounting(int value)
    {
        value = currentValue;
        for (currentValue = 0; value <= 10;)
        {
            return value++;

            Debug.Log(value.ToString());
        }
        return value;
    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
