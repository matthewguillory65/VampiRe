using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    readonly bool alive = true;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    ///Found this online, seemed usedful

    /*void GrabObject()
     {
        grabbing = true;
        setHandsClosed();

        RaycastHit[] hits;
        hits = Physics.SphereCastAll(transform.position, grabRadius, transform.forward, 0f, grabMask);

        if (hits.Length > 0)
        {
            int closestHit = 0;
            for (int i = 0; i < hits.Length; i++)
            {
 
                if (hits[i].distance < hits[closestHit].distance)
                {                  
                    closestHit = i;                  
                }
            }
 
            //test if youre already holding the object in another hand
            if (hits[closestHit].transform.gameObject.GetComponent<grabbableObject>().held == false)
            {
                //move object to your hand
                grabbedObject = hits[closestHit].transform.gameObject;
                grabbedObject.GetComponent<Rigidbody>().isKinematic = true;
                grabbedObject.transform.position = transform.position;
                grabbedObject.transform.parent = transform;
                grabbedObject.GetComponent<grabbableObject>().held = true;
            }
 
        }
     }*/
}
