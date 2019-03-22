using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class AudioTrigger : MonoBehaviour
{
    protected AudioSource tick;
    public Dropdown drop;
    
    //public GameObject thing;
    //float hearingThreshold = 3.0f;
    //Use this for initialization

    void Start()
    {
        tick = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    //void CanItHearMe()
    //{
    //    float sqDist = (thing.transform.position - tick.transform.position).sqrMagnitude;
    //    float percievedLoudness = tick.volume / sqDist;
    //    //Depending on where you are when the sound is played depends on how loud it will be
    //    if (percievedLoudness < hearingThreshold)
    //    {
    //        Debug.Log("It can hear this");
    //    }
    //}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            tick.Play();
            //t.WhichSoundCloser();
            print("Made Sound");
        }
    }


}

