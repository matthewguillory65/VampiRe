using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRTestBehaviorInputAxis : MonoBehaviour
{

    public GameObject collidingObject, objectInHand;
    public float TestAxis;
    public string inputName = "PrimaryControllerHandTrigger";
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        TestAxis = Input.GetAxis(inputName);
    }
}
