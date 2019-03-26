using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLerp : MonoBehaviour
{
    private GameObject Throwable;
    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.CompareTag("Plane"))
    //    {
    //        SoundToLerp.Invoke("RaiseEvent", 5);
    //        Debug.Log("Should be Lerping.");
    //    }

    //    if (SoundToLerp.isLerping==true)
    //    {
    //        SoundToLerp.Invoke("RaiseEvent", 5);
    //        Debug.Log("Should be Lerping.");
    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
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
