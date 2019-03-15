using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SetStaticHandsReference : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject sphere;
    
    private void Start()
    {
        HandsReference.LeftHand = null;
        HandsReference.RightHand = null;
    }


    
}

public static class HandsReference
{
    public static GameObject LeftHand;
    public static GameObject RightHand;
    public static GameObject Sphere;
}


