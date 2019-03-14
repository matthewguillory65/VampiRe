using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditorInternal;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Assets.Scripts.Brett
{
    public class IntroRunningState : State
    {

        public override void OnEnter()
        {
            Debug.Log("IntroRunningState");
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c)
        {
            //Can transition to IntroPauseState, IntroRunningState, or GameStart state
        }
    }
}
