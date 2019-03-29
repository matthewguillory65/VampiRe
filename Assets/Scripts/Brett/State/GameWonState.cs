using System;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [Serializable]
    public class GameWonState : State
    {
        public override void OnEnter()
        {
            Debug.Log("GameWonState");
        }

        public override void OnExit()
        {
        }

        public override void Update(Context c, ConditionScriptable conditionScriptable)
        {
            //Can Transition into ExitState or IntroStartState
        }
    }
}