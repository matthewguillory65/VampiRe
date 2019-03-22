using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceToInteraction
{
    public static Object _instance;
    public static Object Player
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<Object>();
            }

            return _instance;
        }
    }
}