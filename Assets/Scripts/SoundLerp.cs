using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoundLerp : MonoBehaviour
{
    public Vector3 StartPos;
    public Vector3 EndPos;
    public GameObject Throwable;
    public  GameEvent TriggerLerp;

    public bool isLerping;
	// Use this for initialization
    private void RaiseEvent()
    {
        do
        {
            Throwable.transform.localScale.Scale(Vector3.Lerp(StartPos, EndPos, 5));
        } while (isLerping==true);

    }
    

    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update ()
    {

    }
}
