using System;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [Serializable]
    public class GameStartState : State
    {
        public override void OnEnter()
        {
            Debug.Log("GameStartState");
        }

        public override void OnExit()
        {
        }

        public override void Update(Context c, ConditionScriptable conditionScriptable)
        {
            //Transitions into GameRunningState
        }
    }
}