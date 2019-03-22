using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Brett;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Events;
public class OnTriggerListener : GameEventListener
{
    // Use this for initialization

    private void OnEnable()
    {
        Event.Subscribe(this);
    }

    private void OnDisable()
    {
        Event.UnSubscribe(this);
    }
}
