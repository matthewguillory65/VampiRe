using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLerp : ValueLerping
{
    private GameObject Obj;
    public GameEvent LerpTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BallNoiseMaker"))
        {
            LerpTrigger.Raise();
        }
    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
