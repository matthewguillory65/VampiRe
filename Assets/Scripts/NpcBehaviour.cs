using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcBehaviour : MonoBehaviour
{
    public bool isDead;
    public bool rightShoulderGrabbed;
    public bool leftShoulderGrabbed;
    Animator anim;

    void Start() 
    {
        anim = GetComponent<Animator>();
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
            anim.SetBool("isDead", true);
        }
	}
}
