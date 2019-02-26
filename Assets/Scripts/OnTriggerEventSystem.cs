using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Collider))]
public class OnTriggerEventSystem : MonoBehaviour
{
    [FormerlySerializedAs("PlayerTag")] public string playerTag;
    [FormerlySerializedAs("TriggerEnter")] public GameEvent playerTriggerEnter;
    [FormerlySerializedAs("TriggerEnd")] public GameEvent playerTriggerEnd;
    [FormerlySerializedAs("TriggerStay")] public GameEvent playerTriggerStay;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag)==true)
        {
            playerTriggerEnter.Raise();
            Debug.Log("Trigger Start.");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag)==true)
        {
            playerTriggerEnd.Raise();
            Debug.Log("Trigger Stop.");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(playerTag)== true)
        {
            playerTriggerStay.Raise();
        }
    }
}