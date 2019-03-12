using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class ThrownObjectBehaviour : MonoBehaviour
{
    public Collider Trigger;


    private void ScaleObject(GameObject TempObj)
    {
        
    }
	// Use this for initialization
    void Start ()
    {
        Trigger = GetComponent<Collider>();
        Trigger.enabled = !Trigger.isTrigger;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
