using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Collider))]
public class OnTriggerEventSystem : MonoBehaviour
{
    [FormerlySerializedAs("PlayerTag")] public string playerTag;
    [FormerlySerializedAs("TriggerEnter")] public GameEvent triggerEnter;
    [FormerlySerializedAs("TriggerEnd")] public GameEvent triggerEnd;
    [FormerlySerializedAs("TriggerStay")] public GameEvent triggerStay;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag)==true)
        {
            triggerEnter.Raise();
            Debug.Log("Trigger Start.");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag)==true)
        {
            triggerEnd.Raise();
            Debug.Log("Trigger Stop.");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(playerTag)== true)
        {
            triggerStay.Raise();
        }
    }
}