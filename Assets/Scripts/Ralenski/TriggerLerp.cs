using System.Collections;
using System.Collections.Generic;
using Ralenski;
using UnityEngine;

public class TriggerLerp : MonoBehaviour
{
    public GameObject ground;
    void OnCollisionEnter(Collision other)
    {
        if (other.rigidbody.gameObject.CompareTag("Throwable"))
        //if the other rigidbody's gameobject's tag is equal to Throwable is true.
        {
            other.rigidbody.gameObject.GetComponent<LerpBehaviour>().enabled = true;
            //enable the lerp behaviour script on the throwable object.
            Debug.Log("Collision with throwable detected");
            Debug.Log("Lerping should start now");
        }
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
