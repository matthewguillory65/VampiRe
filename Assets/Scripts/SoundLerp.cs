using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class SoundLerp : MonoBehaviour
{
    [Range(0,5)]
    public float SliderValue;
    public float Result;
    public GameObject sphereObject;
    public SphereCollider sphereCollider;
    public LerpOBJ lerpOBJ;
    public TimeOBJ timer = new TimeOBJ{ Max = 5 };


   
    public struct TimeOBJ
    {
        private float val;

        public float value
        {

            get { return val > Max ? 0 : value; }
            set { this.val = value; }

        }
        public float Max { get; set; }

    }

    public struct LerpOBJ
    {
        public float Beginning;
        public float Ending;
        public float Interprolent;

        public float Answer
        {
            get { return (Ending - Beginning) * Interprolent; }
        }
    }

    // Use this for initialization
        void Start()
    {
        sphereObject= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphereCollider = sphereObject.AddComponent<SphereCollider>();
        sphereCollider.radius = Result;


    }
    // Update is called once per frame
    void Update()
    {

    }

    }
