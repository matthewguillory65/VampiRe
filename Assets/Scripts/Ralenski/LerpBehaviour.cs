using System;
using Assets.Scripts.Brett;
using UnityEngine;

namespace Ralenski
{
    public class LerpBehaviour : MonoBehaviour
    {
        public bool scrpitON;
        [Range(0, 5)]
        public float sliderVal;
        [HideInInspector]
        public GameObject throwableOBJ;
        [TextArea, SerializeField] private string Note;
        public SphereCollider sphereCol;
        public LerpOBJ lerpOBJ;
        public TimeOBJ timeOBJ;

        void enableScript()
        {
            if (scrpitON == false)
            {
                throwableOBJ.GetComponent<LerpBehaviour>().enabled = false;
            }

            if (scrpitON == true)
            {
                throwableOBJ.GetComponent<LerpBehaviour>().enabled = true;
            }
        }
        [Serializable]
        public struct TimeOBJ
        {
            private float _value;
            public float Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = _value >= Max ? Max : value; //is _value greater than max ? yes => return Max otherwise return the _value
                }
            }
            public float Max { get; set; }
        }
        [Serializable]
        public struct LerpOBJ
        {
            public float Beginning
            {
                get;
                set;
            }

            public float Ending
            {
                get;
                set;
            }

            public float Interprolant
            {
                get;
                set; 
            }
            [SerializeField]
            private float _result;
            public float Result
            {
                get
                {
                    _result = Beginning + ((Ending - Beginning) * Interprolant);
                    return _result;
                }
            }
        }
        // Use this for initialization
        void Start()
        {
            
            timeOBJ = new TimeOBJ
            {
                Max = 5,
                Value = sliderVal
            };
            lerpOBJ = new LerpOBJ
            {
                Beginning = 0,
                Ending = timeOBJ.Max,
                Interprolant = timeOBJ.Value //set the ending of the lerp object
            };
            throwableOBJ = GameObject.CreatePrimitive(PrimitiveType.Sphere);//create a sphere
            throwableOBJ.transform.SetParent(transform);
            sphereCol = throwableOBJ.GetComponent<SphereCollider>();//add a collider and store the reference
            sphereCol.radius = lerpOBJ.Result;//set the radius of the sphere collider
        }
        // Update is called once per frame
        void Update()
        {
            timeOBJ.Value += Time.deltaTime;//update the timer
            sliderVal = timeOBJ.Value;//set the slider to the time objects value
            lerpOBJ.Interprolant = sliderVal / timeOBJ.Max; //set the interprolant to the sliders value
            sphereCol.radius = lerpOBJ.Result;//set the result to be the lerp result
        }
    }
}