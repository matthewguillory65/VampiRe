using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditorInternal;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [System.Serializable]
    public class IntroRunningState : State
    {

        public override void OnEnter()
        {
            Debug.Log("IntroRunningState");
        }

        public override void OnExit()
        {

        }

        public override void Update(Context c, ConditionScriptable conditionScriptable)
        {
            //Can transition to IntroPauseState, IntroRunningState, or GameStart state
        }
    }
}
