using System;
using UnityEngine;

namespace Assets.Scripts.Brett
{
    [Serializable]
    public class GameLoseState : State
    {
        public string name = "GAMELOSENAME";

        public override void OnEnter()
        {
            Debug.Log("GameLoseState");
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