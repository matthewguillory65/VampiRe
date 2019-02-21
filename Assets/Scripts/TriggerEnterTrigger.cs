using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]

public class TriggerEnterTrigger : MonoBehaviour
{
    public string compareTag;
    public GameEvent gameEvent;
   
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag(compareTag))
        {
            gameEvent.Raise();
        }
    }

}