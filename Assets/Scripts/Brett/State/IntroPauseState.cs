using System;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [Serializable]
    public class IntroPauseState : State
    {
        public override void OnEnter()
        {
            Debug.Log("IntroPauseState");
        }

        public override void OnExit()
        {
        }

        public override void Update(Context c, ConditionScriptable conditionScriptable)
        {
            //Can transition into IntroRunningState, or ExitState
        }
    }
}