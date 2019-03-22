using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoundLerp : MonoBehaviour
{
    public Vector3 StartSize;
    public Vector3 EndSize;
    public GameObject Throwable;
    public GameEvent TriggerLerp;

    public bool isLerping;
    // Use this for initialization
    //private void RaiseEvent()
    //{
    //    TriggerLerp.Raise();
    //    Throwable.transform.localScale = Vector3.Lerp(StartSize, EndSize,.9f);
    //    var currentSize = StartSize - EndSize;
    //}

    struct  Lerp
    {
        private int start;
        private int end;
        private int interlopepercent;

        void doLerp()
        {
            var pos = end - start * interlopepercent;
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
