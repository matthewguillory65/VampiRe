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

        
        public GameStateScriptable GAMESTATEREF;

        public ConditionScriptable Conditions;

        

        void Start()
        {
            Context.CurrentState = GAMESTATEREF.TheState;

        }

        private void Update()
        {
            Context.Update();
        }
    }
}
