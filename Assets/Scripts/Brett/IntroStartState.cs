using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditorInternal;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    public class IntroStartState : State
    {
        public override void OnEnter()
        {
            //Loads up introduction/hub scene

            Debug.Log("IntroStartState");
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c)
        { 
            //Transitions to IntroRunningState
            
        }
    }
}
