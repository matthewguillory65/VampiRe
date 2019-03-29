using System;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [Serializable]
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

        public override void Update(Context c, ConditionScriptable conditionScriptable)
        {
            if (Input.GetKey(KeyCode.A)) c.ChangeState(new IntroRunningState());
            //Transitions to IntroRunningState
        }
    }
}