using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStaticAudioSourceReference : MonoBehaviour
{
    public AudioSource[] audiosource;
    private void Start()
    {

    }
}



public class HowManyHeard : MonoBehaviour
{
    public AudioSource[] tick;
    public GameObject[] AI, AI2;
    public GameObject currentCorrect;
    //BrainStorming/Options
    public void WhichSoundCloser()
    {
        foreach (var x in tick)
        {
            foreach (var z in AI)
            {
                foreach(var y in AI2)
                {
                    if (Vector3.Distance(z.transform.position, x.transform.position) < Vector3.Distance(y.transform.position, x.transform.position))
                    {
                        currentCorrect = z;
                        print("Capsule is correct");
                    }
                    else
                    {
                        currentCorrect = y;
                        print("Capsule1 is correct");
                    }
                }
            }
        }
    }
}
