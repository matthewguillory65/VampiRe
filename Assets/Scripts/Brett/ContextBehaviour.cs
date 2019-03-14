using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Scripts.Brett
{
    public class ContextBehaviour : MonoBehaviour
    {
        [SerializeField]
        private Context Context;

        

        void Start()
        {
            Context.CurrentState = new IntroStartState();
            
        }

        private void Update()
        {
            Context.Update();
        }
    }
}
