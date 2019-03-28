using System.Collections;
using System.Collections.Generic;
using Ralenski;
using UnityEngine;

public class TriggerLerp : MonoBehaviour
{
    private GameObject Throwable;
    
   

    void OnCollisionEnter(Collision col)
    {
        if (col.rigidbody.transform.parent.CompareTag("Ground"))
        {
            Throwable.GetComponent<LerpBehaviour>().enabled = true;
            print("Should Beginning Lerping");
            print("Should Alert nearby guard");
            
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
