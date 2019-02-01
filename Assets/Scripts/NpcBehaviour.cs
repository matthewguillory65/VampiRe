using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcBehaviour : MonoBehaviour
{
    public bool isDead;
    public bool rightShoulderGrabbed;
    public bool leftShoulderGrabbed;

    void Start() 
    {
        isDead = false;
	}
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            leftShoulderGrabbed = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rightShoulderGrabbed = true;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            isDead = true;
        }
	}
}
