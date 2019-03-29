using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LerpBehaviour : MonoBehaviour
{
    public LerpObject lerpObject;

    [Range(0, 1)]
    public float sliderValue;

    public float Result;

    public TimerObject timer = new TimerObject{Max = 5};

    public GameObject sphereGameObject;
    public SphereCollider sphereCollider;

    private void Start()
    {
        sphereGameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);//make the ball
        sphereCollider = sphereGameObject.AddComponent<SphereCollider>();//add collider
        sphereCollider.radius = Result; //link results

    }

    // Update is called once per frame
    private void Update()
    {
        timer.Value += Time.deltaTime;//add the time past since last frame
        sliderValue = timer.Value;


        lerpObject.Interprolant = sliderValue;
        Result = lerpObject.Result;

        sphereCollider.radius = Result;
    }
}

[Serializable]
public struct TimerObject
{

    private float value;
    public float Value
    {
        get { return value > Max ? 0 : value; } //is value greater than it's max set}
        set{this.value = value;}
    }

    public float Max { get; set; }

}

[Serializable]
public struct LerpObject
{
    public float Start;
    public float End;
    public float Interprolant;
    public float Result
    {
        get
        {
            return (End - Start) * Interprolant;
        }
    }
}